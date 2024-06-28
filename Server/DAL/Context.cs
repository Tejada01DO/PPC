using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<Productos> Productos { get; set; }
    public DbSet<Entradas> Entradas { get; set; }

    public Context(DbContextOptions<Context> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Productos>().HasData
        (
            new Productos
            {
                ProductoId = 1,
                Descripcion = "Leche",
                precioCompra = 8,
                precioVenta = 15,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 2,
                Descripcion = "Pan",
                precioCompra = 15,
                precioVenta = 30,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 3,
                Descripcion = "Huevos",
                precioCompra = 10,
                precioVenta = 25,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 4,
                Descripcion = "Arroz",
                precioCompra = 25,
                precioVenta = 50,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 5,
                Descripcion = "Pasta",
                precioCompra = 30,
                precioVenta = 60,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 6,
                Descripcion = "Frutas",
                precioCompra = 30,
                precioVenta = 60,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 7,
                Descripcion = "Verduras",
                precioCompra = 25,
                precioVenta = 50,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 8,
                Descripcion = "Carne",
                precioCompra = 50,
                precioVenta = 100,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 10,
                Descripcion = "Pescado",
                precioCompra = 40,
                precioVenta = 80,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 11,
                Descripcion = "Aceite de oliva",
                precioCompra = 35,
                precioVenta = 70,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 12,
                Descripcion = "Yogurt",
                precioCompra = 30,
                precioVenta = 60,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 13,
                Descripcion = "Queso",
                precioCompra = 40,
                precioVenta = 80,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 14,
                Descripcion = "Mantequilla",
                precioCompra = 30,
                precioVenta = 60,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 15,
                Descripcion = "Galletas",
                precioCompra = 20,
                precioVenta = 40,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 16,
                Descripcion = "Cereal",
                precioCompra = 25,
                precioVenta = 50,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 17,
                Descripcion = "Jugo",
                precioCompra = 20,
                precioVenta = 40,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 18,
                Descripcion = "Refresco",
                precioCompra = 20,
                precioVenta = 40,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 19,
                Descripcion = "Cerveza",
                precioCompra = 20,
                precioVenta = 40,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 20,
                Descripcion = "Vino",
                precioCompra = 30,
                precioVenta = 60,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 21,
                Descripcion = "Café",
                precioCompra = 20,
                precioVenta = 40,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 22,
                Descripcion = "Azúcar",
                precioCompra = 15,
                precioVenta = 30,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 23,
                Descripcion = "Sal",
                precioCompra = 10,
                precioVenta = 20,
                Existencia = 200
            },

            new Productos
            {
                ProductoId = 24,
                Descripcion = "Papel Higienico",
                precioCompra = 15,
                precioVenta = 30,
                Existencia = 200
            }
        );
    }
}

