﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VETERINARIA_EL_BOSQUEEntities : DbContext
    {
        public VETERINARIA_EL_BOSQUEEntities()
            : base("name=VETERINARIA_EL_BOSQUEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ANUNCIOS> ANUNCIOS { get; set; }
        public virtual DbSet<ANUNCIOS_ENVIADOS> ANUNCIOS_ENVIADOS { get; set; }
        public virtual DbSet<ARTICULOS> ARTICULOS { get; set; }
        public virtual DbSet<ARTICULOS_PROVEEDOR> ARTICULOS_PROVEEDOR { get; set; }
        public virtual DbSet<CAJAS> CAJAS { get; set; }
        public virtual DbSet<CAMPA_AS> CAMPA_AS { get; set; }
        public virtual DbSet<CAMPA_AS_PARTICIPANTES> CAMPA_AS_PARTICIPANTES { get; set; }
        public virtual DbSet<CANTONES> CANTONES { get; set; }
        public virtual DbSet<CITAS> CITAS { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<COBROS> COBROS { get; set; }
        public virtual DbSet<CONSULTORIO> CONSULTORIO { get; set; }
        public virtual DbSet<CREDITOS> CREDITOS { get; set; }
        public virtual DbSet<DEPARTAMENTOS> DEPARTAMENTOS { get; set; }
        public virtual DbSet<DESPACHO> DESPACHO { get; set; }
        public virtual DbSet<DETALLE_ARTICULOS> DETALLE_ARTICULOS { get; set; }
        public virtual DbSet<DETALLE_SERVICIO> DETALLE_SERVICIO { get; set; }
        public virtual DbSet<DISTRITOS> DISTRITOS { get; set; }
        public virtual DbSet<ESTADOS> ESTADOS { get; set; }
        public virtual DbSet<FACTURA_COMPRA> FACTURA_COMPRA { get; set; }
        public virtual DbSet<FACTURA_PROMOCION> FACTURA_PROMOCION { get; set; }
        public virtual DbSet<FACTURAS> FACTURAS { get; set; }
        public virtual DbSet<INVENTARIO> INVENTARIO { get; set; }
        public virtual DbSet<MARCAS> MARCAS { get; set; }
        public virtual DbSet<MASCOTAS> MASCOTAS { get; set; }
        public virtual DbSet<METODO_PAGO> METODO_PAGO { get; set; }
        public virtual DbSet<MOTIVO_CITA> MOTIVO_CITA { get; set; }
        public virtual DbSet<NOMINA> NOMINA { get; set; }
        public virtual DbSet<NOMINA_PERSONAL> NOMINA_PERSONAL { get; set; }
        public virtual DbSet<OBSERVACIONES> OBSERVACIONES { get; set; }
        public virtual DbSet<PARTICIPANTES> PARTICIPANTES { get; set; }
        public virtual DbSet<PERSONAL> PERSONAL { get; set; }
        public virtual DbSet<PROMOCIONES> PROMOCIONES { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<PROVINCIAS> PROVINCIAS { get; set; }
        public virtual DbSet<PRUEBAS> PRUEBAS { get; set; }
        public virtual DbSet<PRUEBAS_LABORATORIO> PRUEBAS_LABORATORIO { get; set; }
        public virtual DbSet<PRUEBAS_PARTICIPANTES> PRUEBAS_PARTICIPANTES { get; set; }
        public virtual DbSet<PUESTOS> PUESTOS { get; set; }
        public virtual DbSet<RECETAS> RECETAS { get; set; }
        public virtual DbSet<RECLUTAMIENTO> RECLUTAMIENTO { get; set; }
        public virtual DbSet<REQUISITOS_PARTICIPANTES> REQUISITOS_PARTICIPANTES { get; set; }
        public virtual DbSet<REQUISITOS_PUESTO> REQUISITOS_PUESTO { get; set; }
        public virtual DbSet<RESULTADO_LABORATORIO> RESULTADO_LABORATORIO { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<SERVICIOS> SERVICIOS { get; set; }
        public virtual DbSet<SERVICIOS_EXPRESS> SERVICIOS_EXPRESS { get; set; }
        public virtual DbSet<SOLICITUD_ARTICULOS> SOLICITUD_ARTICULOS { get; set; }
        public virtual DbSet<SOLICITUD_COMPRA> SOLICITUD_COMPRA { get; set; }
        public virtual DbSet<TABLAS> TABLAS { get; set; }
        public virtual DbSet<TIPO_ANIMAL> TIPO_ANIMAL { get; set; }
        public virtual DbSet<TIPO_CONSULTORIO> TIPO_CONSULTORIO { get; set; }
        public virtual DbSet<TIPO_MARCA> TIPO_MARCA { get; set; }
        public virtual DbSet<TIPO_PAGO> TIPO_PAGO { get; set; }
        public virtual DbSet<USUARIO_ROL> USUARIO_ROL { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<VACACIONES> VACACIONES { get; set; }
    }
}