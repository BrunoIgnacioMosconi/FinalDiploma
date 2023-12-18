namespace DATOS
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class EMPRESA : DbContext
    {
        public static EMPRESA instancia;
        public static EMPRESA ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new EMPRESA();
            }
            return instancia;
        }
        public EMPRESA()

                  : base("name=EMPRESA")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MODELO.USUARIO>()
                .HasKey(_ => _.cod_usuario)
                .HasMany(_ => _.GRUPOs)
                .WithMany(_ => _.USUARIOS)
                .Map(_ => _.ToTable("USUARIO_GRUPO").MapLeftKey("cod_usuario").MapRightKey("cod_grupo"));

            modelBuilder.Entity<MODELO.GRUPO>()
               .HasKey(_ => _.cod_grupo)
               .HasMany(_ => _.ACCIONES)
               .WithRequired(_ => _.Grupo);

            modelBuilder.Entity<MODELO.REMITO>()
              .HasKey(_ => _.cod_remito)                          
              .HasMany(_ => _.ITEMS)
              .WithOptional(_ => _.oREMITO);

            modelBuilder.Entity<MODELO.AUDITORIA_PRODUCTO>()
            .HasKey(_ => _.cod_auditoriaP);

            modelBuilder.Entity<MODELO.ACCION>()
              .HasKey(_ => _.cod_accion);


            modelBuilder.Entity<MODELO.LOGIN>()
                .HasKey(_ => _.Cod_Login);

            modelBuilder.Entity<MODELO.ITEM>()
               .HasKey(_ => _.cod_item)
               .HasRequired(_ => _.Producto)
              .WithMany(_ => _.ITEMs);

            modelBuilder.Entity<MODELO.FORMAS_DE_PAGO>()
               .HasKey(_ => _.cod_formas_de_pago);

            modelBuilder.Entity<MODELO.CLIENTE>()
                .HasKey(_ => _.cod_cliente);

            modelBuilder.Entity<MODELO.ORDENDECOMPRA>()
                .HasKey(_ => _.cod_orden)          
               .HasRequired(_ => _.cod_proveedor);
            modelBuilder.Entity<MODELO.ORDENDECOMPRA>()
               .HasMany(_ => _.REMITOS)
               .WithRequired(_ => _.oORDENESDECOMPRA);

            modelBuilder.Entity<MODELO.ORDENDECOMPRA>()
            .HasMany(_ => _.ITEMS)
            .WithOptional(_ => _.oORDEN);

            modelBuilder.Entity<MODELO.EMPLEADO>()
                .HasKey(_ => _.cod_empleado);

            modelBuilder.Entity<MODELO.PAGO>()
               .HasKey(_ => _.cod_pago);
            modelBuilder.Entity<MODELO.PAGO>()
           .HasRequired(_ => _.Formas_de_pago);

            modelBuilder.Entity<MODELO.PRODUCTO>()
                .HasKey(_ => _.cod_producto);

            modelBuilder.Entity<MODELO.VENTA>()
                .HasKey(_ => _.cod_venta);

            modelBuilder.Entity<MODELO.VENTA>()
               .HasRequired(_ => _.Cod_empleado);
            modelBuilder.Entity<MODELO.VENTA>()
              .HasRequired(_ => _.Cod_cliente);

            modelBuilder.Entity<MODELO.VENTA>()
                .HasMany(_ => _.ITEMS)
                .WithOptional(_ => _.oVenta);
            modelBuilder.Entity<MODELO.VENTA>()
                .HasMany(_ => _.PAGOS)
                .WithOptional(_ => _.oVenta);

            modelBuilder.Entity<MODELO.PROVEEDOR>()
                .HasKey(_ => _.cod_proveedor);

        }
        public virtual DbSet<MODELO.CLIENTE> CLIENTES { get; set; }
        public virtual DbSet<MODELO.EMPLEADO> EMPLEADOS { get; set; }
        public virtual DbSet<MODELO.ORDENDECOMPRA> ORDENESDECOMPRAS { get; set; }
        public virtual DbSet<MODELO.PAGO> PAGOS { get; set; } 
        public virtual DbSet<MODELO.PRODUCTO> PRODUCTOS { get; set; }
        public virtual DbSet<MODELO.PROVEEDOR> PROVEEDORES { get; set; }
        public virtual DbSet<MODELO.VENTA> VENTAS { get; set; }
        public virtual DbSet<MODELO.ITEM_VENTA> ITEMS_VENTA { get; set; }
        public virtual DbSet<MODELO.ITEM_OC> ITEMS_OC { get; set; }
        public virtual DbSet<MODELO.ITEM_REMITO> ITEMS_REMITO { get; set; }
        public virtual DbSet<MODELO.USUARIO> USUARIOs { get; set; }
        public virtual DbSet<MODELO.GRUPO> GRUPOs { get; set; }
        public virtual DbSet<MODELO.LOGIN> LOGINs { get; set; }
        public virtual DbSet<MODELO.REMITO> REMITOs { get; set; }
        public virtual DbSet<MODELO.ACCION> ACCIONs { get; set; }
        public virtual DbSet<MODELO.AUDITORIA_PRODUCTO> AUDITORIAS_PROCUTO { get; set; }

    }


}