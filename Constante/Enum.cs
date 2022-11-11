using System.ComponentModel;

namespace Constante
{
    public enum TypeMenu
    {
        Portfolio,
        Login,
        Portal
    }
    
    public enum Genr
    {
        [Description("Masculino")]
        Masculine,
        [Description("Feminino")]
        Feminine
    }

    public enum RaceColor
    {
        [Description("Branca")]
        White,
        [Description("Preta")]
        Black,
        [Description("Parda")]
        Brown,
        [Description("Amarela")]
        Yellow,
        [Description("Indígena")]
        Indigenous
    }

    public enum CvilStatus
    {
        [Description("Solteiro")]
        Single,
        [Description("Casado")]
        Married,
        [Description("Divorciado")]
        Divorced,
        [Description("Separado")]
        Separate,
        [Description("Viúvo")]
        Widower
    }

    public enum InstructionDegree
    {
        [Description("Analfabeto, inclusive o que, embora tenha recebido instrução, não se alfabetizou")]
        Unlettered,
        [Description("Até o 5º ano incompleto do Ensino Fundamental (antiga 4ª série) ou que se tenha alfabetizado sem ter frequentado escola regular")]
        IncompleteFifthYear,
        [Description("5º ano completo do Ensino Fundamental")]
        CompleteFifthYear,
        [Description("Do 6º ao 9º ano do Ensino Fundamental incompleto (antiga 5ª a 8ª série)")]
        ElementarySchoolIncomplete,
        [Description("Ensino Fundamental Completo")]
        ElementarySchoolComplete,
        [Description("Ensino Médio Incompleto")]
        HighSchoolIncomplete,
        [Description("Ensino Médio Completo")]
        HighSchoolComplete,
        [Description("Educação Superior Incompleta")]
        UniversityEducationIncomplete,
        [Description("Educação Superior Completa")]
        UniversityEducationComplete,
        [Description("Pós-Graduação Completa")]
        PostgraduateStudiesComplete,
        [Description("Mestrado Completo")]
        MasterOfDegreeComplete,
        [Description("Doutorado Completo")]
        DoctorateDegreeComplete
    }

    public enum TypePerson
    {
        Physical,
        Legal
    }

    public enum SituationCommunication
    {
        Pending,
        Sent, 
        Error, 
        WaitingReturn
    }
}