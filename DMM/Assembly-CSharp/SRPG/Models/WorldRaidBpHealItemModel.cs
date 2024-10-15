// Decompiled with JetBrains decompiler
// Type: SRPG.Models.WorldRaidBpHealItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033DF")]
  public class WorldRaidBpHealItemModel
  {
    [Token(Token = "0x400F5C0")]
    [FieldOffset(Offset = "0x18")]
    private WorldRaidBpHealParam.HealInfo mInfo;

    [Token(Token = "0x17002154")]
    public int MinCount
    {
      [Token(Token = "0x600E881"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E882"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17002155")]
    public int MaxCount
    {
      [Token(Token = "0x600E883"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E884"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x17002156")]
    public bool DispMaxCount
    {
      [Token(Token = "0x600E885"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E886"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] private set
      {
      }
    }

    [Token(Token = "0x17002157")]
    public int NeedCoin
    {
      [Token(Token = "0x600E887"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600E888"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x600E889")]
    [Address(RVA = "0xAD5140", Offset = "0xAD3F40", VA = "0x10AD5140")]
    public void Initialize(WorldRaidBpHealParam.HealInfo _info)
    {
    }

    [Token(Token = "0x600E88A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidBpHealItemModel()
    {
    }
  }
}
