using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace School;

public class Student
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public String Name { get; set; }

    [Required]
    public DateTime BirthData { get; set; }

    // Parimaters Constructor
    public Student(int Id, String Name, DateTime BirthData)
    {
        this.Id = Id;
        this.Name = Name;
        this.BirthData = BirthData;
    }
}

















