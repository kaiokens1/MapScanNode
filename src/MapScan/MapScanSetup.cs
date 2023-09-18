using System;
using System.Collections.Generic;
using Blockcore.Consensus.Checkpoints;
using Blockcore.NBitcoin;
using MapScan.Networks;
using MapScan.Networks.Setup; 

namespace MapScan
{
   internal class MapScanSetup
   {
      internal static MapScanSetup Instance = new MapScanSetup();

      internal CoinSetup Setup = new()
      {
         FileNamePrefix = "",
         ConfigFileName = ".conf",
         Magic = "01-4D-59-47",
         CoinType = 36001, // SLIP-0044: https://github.com/satoshilabs/slips/blob/master/slip-0044.md,
         PremineReward = 1000000,
         PoWBlockReward = 10,
         PoSBlockReward = 15,
         LastPowBlock = 25000,
         GenesisText = "Map Scan Is Best", // The New York Times, 2020-04-16
         TargetSpacing = TimeSpan.FromSeconds(64),
         ProofOfStakeTimestampMask = 0x0000000F, // 0x0000003F // 64 sec
         PoSVersion = 3
      };

      internal NetworkSetup Main = new()
      {
         Name = "MapScanMain",
         RootFolderName = "",
         CoinTicker = "MSN",
         DefaultPort = 15001,
         DefaultRPCPort = 15002,
         DefaultAPIPort = 15003,
         PubKeyAddress = 50, // B https://en.bitcoin.it/wiki/List_of_address_prefixes
         ScriptAddress = 110, // b
         SecretAddress = 160,
         GenesisTime = 1694680418,
         GenesisNonce = 1655147,
         GenesisBits = 0x1E0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "00000db2d3468883fbbd110e07d8102d7886f27cdc2e7d91031e8bf1d8ee6f10",
         HashMerkleRoot = "fe024cc4053b15314d87f5169eb5894de20edb416728bbd00380d27aeb9d8d38",
         DNS = new[] { "seed.mycoin.net", "seed.mycoin.com", "msn.seed.blockcore.net" },
         Nodes = new[] { "23.23.23.23", "24.24.24.24" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup RegTest = new NetworkSetup
      {
         Name = "MapScanRegTest",
         RootFolderName = "regtest",
         CoinTicker = "TMSN",
         DefaultPort = 25001,
         DefaultRPCPort = 25002,
         DefaultAPIPort = 25003,
         PubKeyAddress = 111,
         ScriptAddress = 196,
         SecretAddress = 239,
         GenesisTime = 1694680488,
         GenesisNonce = 8048,
         GenesisBits = 0x1F00FFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "0000c7ed1c6368c922e385812be32095059697556d248f109f18ea24de33ff8d",
         HashMerkleRoot = "a0c2163d204a7abc800c889e55b5c60b4e0b07b71a7f72d062a6e8f339ff571d",
         DNS = new[] { "seedregtest1.msn.blockcore.net", "seedregtest2.msn.blockcore.net", "seedregtest.msn.blockcore.net" },
         Nodes = new[] { "23.23.23.23", "24.24.24.24" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup Test = new NetworkSetup
      {
         Name = "MapScanTest",
         RootFolderName = "test",
         CoinTicker = "TMSN",
         DefaultPort = 35001,
         DefaultRPCPort = 35002,
         DefaultAPIPort = 35003,
         PubKeyAddress = 111,
         ScriptAddress = 196,
         SecretAddress = 239,
         GenesisTime = 1694680489,
         GenesisNonce = 12563,
         GenesisBits = 0x1F0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "000dcdb107e8fd803490f859f86fc7ce300e0b278aa41b45d545699cffff3eb5",
         HashMerkleRoot = "7e8d6c453809ad5b6c6d87d9321f8043380e07be1bd4a7d6877b51b664721a45",
         DNS = new[] { "seedtest1.msn.blockcore.net", "seedtest2.msn.blockcore.net", "seedtest.msn.blockcore.net" },
         Nodes = new[] { "23.23.23.23", "24.24.24.24" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      public bool IsPoSv3()
      {
         return Setup.PoSVersion == 3;
      }

      public bool IsPoSv4()
      {
         return Setup.PoSVersion == 4;
      }
   }
}
