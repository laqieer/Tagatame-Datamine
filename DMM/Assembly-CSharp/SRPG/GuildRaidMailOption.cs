// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidMailOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FB6")]
  public class GuildRaidMailOption
  {
    [Token(Token = "0x170005AE")]
    public int TotalPage
    {
      [Token(Token = "0x6004115"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004116"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x6004117")]
    [Address(RVA = "0x1192CB0", Offset = "0x1191AB0", VA = "0x11192CB0")]
    public bool Deserialize(JSON_GuildRaidMailOption json) => new bool();

    [Token(Token = "0x6004118")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidMailOption()
    {
    }
  }
}
