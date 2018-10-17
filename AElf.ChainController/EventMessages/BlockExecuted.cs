using AElf.Kernel;

namespace AElf.ChainController.EventMessages
{
    public sealed class BlockExecuted
    {
        public BlockExecuted(IBlock block)
        {
            Block = block;
        }

        public IBlock Block { get; }
    }
}