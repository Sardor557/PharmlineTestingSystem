using System;

namespace PharmlineTestingSystem.Shared.ViewModels
{
    public sealed class viAnswer
    {
        public int Id { get; set; }
        public string Question {  get; set; }
        public int QuestionId {  get; set; }

        public int EmployeeId { get; set; }
        public string EmployeeName {  get; set; }
                
        public string Option {  get; set; }
        public int OptionId { get; set; }
        public bool IsCorrect { get; set; }

        public string Drug {  get; set; }
        public int DrugId { get; set; }

        public DateTime AnswerDate {  get; set; }
    }
}
