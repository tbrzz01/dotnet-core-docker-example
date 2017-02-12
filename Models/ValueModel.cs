

using System;
using System.ComponentModel.DataAnnotations;

///
//  Value Model
///
public class ValueModel
{
    // Id
    [Required]
    public Guid Id {get;set;}
    // Name
    public string Name {get;set;}
    // Description
    public string Description{get;set;}
}