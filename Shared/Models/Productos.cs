using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Productos
{
    [Key]
    public int ProductoId { get; set; }
    [Required(ErrorMessage = "La descripcion es un campo obligatorio")]
    public string? Descripcion { get; set; }
    [Required(ErrorMessage = "Es necesario especificar el precio con el que se compro el producto")]
    public double precioCompra { get; set; }
    [Required(ErrorMessage = "Es necesario especificar el precio con el que se vende el producto")]
    public double precioVenta { get; set; }
    [Required(ErrorMessage = "Es necesario especificar la cantidad de productos que existen")]
    public int Existencia { get; set; }
}