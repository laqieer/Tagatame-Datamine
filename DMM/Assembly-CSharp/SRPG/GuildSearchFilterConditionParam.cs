// Decompiled with JetBrains decompiler
// Type: SRPG.GuildSearchFilterConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D45")]
  public class GuildSearchFilterConditionParam
  {
    [Token(Token = "0x400730D")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x400730E")]
    [FieldOffset(Offset = "0xC")]
    public int sval;
    [Token(Token = "0x400730F")]
    [FieldOffset(Offset = "0x10")]
    public int sval_min;
    [Token(Token = "0x4007310")]
    [FieldOffset(Offset = "0x14")]
    public int sval_max;

    [Token(Token = "0x60077F1")]
    [Address(RVA = "0x391A80", Offset = "0x390880", VA = "0x10391A80")]
    public void Deserialize(JSON_GuildSearchFilterConditionParam json)
    {
    }

    [Token(Token = "0x60077F2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildSearchFilterConditionParam()
    {
    }
  }
}
