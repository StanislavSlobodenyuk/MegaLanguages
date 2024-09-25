﻿
using Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity.Content.Question
{
    public class TestQuestion : BaseQuestion
    {
        public TestRightAnswer? RightAnswer { get; set; }
        public int RightAnswerId { get; set; }

        public IEnumerable<TestAnswerOption> AnswerOptions { get; set; } = new List<TestAnswerOption>();

        protected TestQuestion() { }
        public TestQuestion(string? questionText) : base(questionText)
        {
        }
    }
}
