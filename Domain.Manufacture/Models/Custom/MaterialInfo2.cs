#nullable enable

using System.ComponentModel.DataAnnotations;

namespace Sylex.ISYS.Domain.Manufacture.Models.Custom;

/// <summary>
/// material properties that are commonly used in this context
/// </summary>
public  class MaterialInfo2
{
    public int Id { get; set; }
    
    [Display(Name = "Kód sylex", ShortName = "PN")]
    public string KódMateriálu { get; set; } = string.Empty;
    public string? Popis { get; set; }

    [Display(Name = "Kód dodávateľa")]
    public string? KódDodavateľa { get; set; }

    [Display(Name = "Merná jednotka", ShortName = "MJ")]
    public string? MJ { get; set; }
 
    /// <summary>
    /// see <see cref="MaterialType"/>
    /// </summary>
    public string? Druh { get; set; }

}    
