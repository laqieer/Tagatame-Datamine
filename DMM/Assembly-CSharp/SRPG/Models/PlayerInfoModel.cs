// Decompiled with JetBrains decompiler
// Type: SRPG.Models.PlayerInfoModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003374")]
  public class PlayerInfoModel
  {
    [Token(Token = "0x400F328")]
    [FieldOffset(Offset = "0x8")]
    private string mName;
    [Token(Token = "0x400F329")]
    [FieldOffset(Offset = "0xC")]
    private string mCustomID;

    [Token(Token = "0x17001F4C")]
    public string Name
    {
      [Token(Token = "0x600E476"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F4D")]
    public string CustomID
    {
      [Token(Token = "0x600E477"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E478")]
    [Address(RVA = "0xABB600", Offset = "0xABA400", VA = "0x10ABB600")]
    public void Initialize(PlayerData player)
    {
    }

    [Token(Token = "0x600E479")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PlayerInfoModel()
    {
    }
  }
}
