﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using c_sharp_dotnet_development_lab_3AI_project.database.entities.group;
using c_sharp_dotnet_development_lab_3AI_project.database.entities.payment_record;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_dotnet_development_lab_3AI_project.database.entities.payment;

[PrimaryKey(nameof(Id))]
public class Payment
{
    [Key] public Guid Id { get; init; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; init; }

    public PaymentType Type { get; set; }
    [MaxLength(64)] public string Name { get; set; }
    [MaxLength] public string Description { get; set; }

    public Guid GroupId { get; set; }
    public Group Group { get; set; } = null!;

    public ICollection<PaymentRecord> PaymentRecords { get; set; }
}

public enum PaymentType
{
    PURCHASE = 1,
    REPAYMENT = 2,
}