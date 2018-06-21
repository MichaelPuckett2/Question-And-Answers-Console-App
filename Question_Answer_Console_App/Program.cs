using System;
using System.Collections.Generic;
using System.Linq;

namespace Question_Answer_Console_App
{
    class Program
    {

        static void Main(string[] args)
        {
            var idCounter = 0;
            var existingStateModels = new List<StateModel>()
            {
                new StateModel() { Id = ++idCounter, State = "AL", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "AK", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "AZ", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "AR", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "CA", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "CO", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "CT", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "DE", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "FL", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "GA", IsActive = true },
                new StateModel() { Id = ++idCounter, State = "HI", IsActive = true },
                new StateModel() { Id = ++idCounter, State = "ID", IsActive = true },
                new StateModel() { Id = ++idCounter, State = "IL", IsActive = true },
                new StateModel() { Id = ++idCounter, State = "IN", IsActive = true },
                new StateModel() { Id = ++idCounter, State = "IA", IsActive = true },
                new StateModel() { Id = ++idCounter, State = "KS", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "KY", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "LA", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "ME", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "MD", IsActive = null }
            };

            idCounter = 0;
            var newStateModels = new List<StateModel>()
            {
                new StateModel() { Id = ++idCounter, State = "AL", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "AK", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "AZ", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "AR", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "CA", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "CO", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "CT", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "DE", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "FL", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "GA", IsActive = true },
                new StateModel() { Id = ++idCounter, State = "HI", IsActive = false },
                new StateModel() { Id = ++idCounter, State = "ID", IsActive = true },
                new StateModel() { Id = ++idCounter, State = "IL", IsActive = true },
                new StateModel() { Id = ++idCounter, State = "IN", IsActive = false },
                new StateModel() { Id = ++idCounter, State = "IA", IsActive = true },
                new StateModel() { Id = ++idCounter, State = "KS", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "KY", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "LA", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "ME", IsActive = null },
                new StateModel() { Id = ++idCounter, State = "MD", IsActive = true }
            };

            var updatedStateModels = from existingModel in existingStateModels
                                     join newModel in newStateModels
                                     on existingModel.Id equals newModel.Id
                                     where existingModel.IsActive != newModel.IsActive
                                     select newModel;

            foreach (var stateModel in updatedStateModels)
            {
                Console.WriteLine($"Id: {stateModel.Id}\tState: {stateModel.State}\tIsActive: {GetIsActiveValue(stateModel.IsActive)}");
            }

            Console.Read();
        }

        private static string GetIsActiveValue(bool? isActive)
        {
            switch (isActive)
            {
                case true: return "1";
                case false: return "0";
                case null:
                default: return "NULL";
            }
        }

        /* 
         * Outputs:
         * Id: 11  State: HI       IsActive: 0
         * Id: 14  State: IN       IsActive: 0
         * Id: 20  State: MD       IsActive: 1 
         */
    }

    public class StateModel
    {
        public int Id { get; set; }
        public string State { get; set; }
        public bool? IsActive { get; set; }
    }
}
 