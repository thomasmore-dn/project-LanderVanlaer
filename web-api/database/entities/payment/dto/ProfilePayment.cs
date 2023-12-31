﻿using AutoMapper;

namespace c_sharp_dotnet_development_lab_3AI_project.database.entities.payment.dto;

public class ProfilePayment : Profile
{
    public ProfilePayment()
    {
        CreateMap<Payment, PaymentReadDto>();
        CreateMap<PaymentWriteDto, Payment>();
    }
}