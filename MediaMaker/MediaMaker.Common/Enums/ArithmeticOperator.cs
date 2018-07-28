using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MediaMaker.Common.Enums
{
    public enum ArithmeticOperator
    {
        [Display(Name = "+")]
        Add = 1,
        [Display(Name = "-")]
        Subtract,
        [Display(Name = "x")]
        Multiply,
        [Display(Name = "÷")]
        Divide
    }
}
