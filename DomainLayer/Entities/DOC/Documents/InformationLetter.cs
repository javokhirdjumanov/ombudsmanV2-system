﻿using DomainLayer.Constants;
using DomainLayer.Entities.INFO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Entities.DOC;
[Table(TableNames.InformationLetter)]
public class InformationLetter
{
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Axborot xati raqami
    /// </summary>
    public int InformationLetterNumber { get; set; }

    /// <summary>
    /// Axborot xati sanasi
    /// </summary>
    public DateTime InformationLetterDate { get; set; }

    /// <summary>
    /// Viza quyuvchilar
    /// </summary>

    /// <summary>
    /// Axborot xati matni
    /// </summary>
    public string InformationLetterText { get; set; }

    /// <summary>
    /// Asosiy ijrochi
    /// </summary>
    public int StateProgramId { get; set; }
    [ForeignKey(nameof(StateProgramId))]
    public StateProgram StateProgram { get; set; }

    /// <summary>
    /// Ham ijrochilar
    /// </summary>
    public string Performers { get; set; }

    /// <summary>
    /// Masul xodim
    /// </summary>
    public string ResponsibleEmployee { get; set; }

    /// <summary>
    /// Telefon raqam
    /// </summary>
    public string PhoneNumber { get; set; }

    public ICollection<VisaHolders> VisaHolders { get; set; }
}