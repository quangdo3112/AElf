﻿using AElf.Management.Models;
using AElf.Management.Services;
using Xunit;

namespace AElf.Management.Tests
{
    public class ChainServiceTest
    {
        //[Fact(Skip = "require aws account")]
        [Fact]
        public void DeployTest()
        {
            var arg = new DeployArg();
            arg.MainChainAccount = "0x04b8b111fdbc2f5409a006339fa1758e1ed1";
            arg.AccountPassword = "123";
            arg.DBArg = new DeployDBArg();
            arg.ManagerArg=new DeployManagerArg();
            arg.ManagerArg.IsCluster = false;
            arg.WorkArg = new DeployWorkArg();
            arg.WorkArg.ActorCount = 4;

            var service = new ChainService();
            service.DeployMainChain(null, arg);
        }
        
        //[Fact(Skip = "require aws account")]
        [Fact]
        public void RemoveTest()
        {
            var service = new SideChainService();

            service.Remove(null);
        }
    }
}