using System.ComponentModel.DataAnnotations;

public class Tbl_Phonebook
{
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    
    public string number { get; set; }
    public string  email { get; set; }
}