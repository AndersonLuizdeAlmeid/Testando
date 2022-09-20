using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryRoutes.Domain.Service
{
    public sealed class MessageService
    {
        public enum Message
        {
            SuccessRegisterCreated,
            ErrorVaccineRecordAlreadyExists,
            ErrorVaccineRelatedRecords,
            ErrorVaccineNotFound,
            ErrorVaccineEmptyDescription,
            ErrorVaccineDoseEmptyDescription,
            ErrorVaccineDoseAlreadyExists,
            ErrorVaccineDoseIsNotValid,
            ErrorVaccineDoseProtectionMonthsIsNotValid,
            WarningVaccineCreation,
            ErrorVaccineDoseNotFound
        }

        public static string GetErrorDescription(Message message)
        {
            switch (message)
            {
                case Message.ErrorVaccineRecordAlreadyExists: return "Já existe um registro com os dados informados";
                case Message.ErrorVaccineRelatedRecords: return "Não foi possível excluir porque existem doses da vacina relacionada a este registro";
                case Message.ErrorVaccineNotFound: return "Vacina não encontrada";
                case Message.ErrorVaccineEmptyDescription: return "A descrição é um campo obrigatório";
                case Message.ErrorVaccineDoseEmptyDescription: return "A descrição da dose é um campo obrigatório";
                case Message.ErrorVaccineDoseAlreadyExists: return "A sequência da dose da vacina já existe";
                case Message.ErrorVaccineDoseIsNotValid: return "A sequência da dose da vacina precisa ser maior que zero";
                case Message.ErrorVaccineDoseProtectionMonthsIsNotValid: return "Os meses de proteção da dose precisam ser maiores que zero";
                case Message.ErrorVaccineDoseNotFound: return "Dose da vacina não encontrada";
                case Message.SuccessRegisterCreated: return "Registro criado com sucesso";
                default: return "Ops, ocorreu um erro";
            }
        }
    }
}