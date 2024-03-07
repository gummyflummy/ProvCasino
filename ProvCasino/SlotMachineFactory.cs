namespace ProvCasino
{
    
    public class SlotMachineFactory : ISlotMachineFactory
    {
        public SlotMachine CreateSlotMachine()
        {
            return new SlotMachine();
        }
    }
}
