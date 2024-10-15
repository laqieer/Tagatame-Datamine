// Decompiled with JetBrains decompiler
// Type: SRPG.GuildSearchFilterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D44")]
  public class GuildSearchFilterParam
  {
    [Token(Token = "0x400730A")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400730B")]
    [FieldOffset(Offset = "0xC")]
    public eGuildSearchFilterTypes filter_type;
    [Token(Token = "0x400730C")]
    [FieldOffset(Offset = "0x10")]
    public GuildSearchFilterConditionParam[] condtions;

    [Token(Token = "0x60077ED")]
    [Address(RVA = "0x391AC0", Offset = "0x3908C0", VA = "0x10391AC0")]
    public void Deserialize(JSON_GuildSearchFilterParam json)
    {
    }

    [Token(Token = "0x60077EE")]
    [Address(RVA = "0x391C30", Offset = "0x390A30", VA = "0x10391C30")]
    public static void Deserialize(
      ref GuildSearchFilterParam[] param,
      JSON_GuildSearchFilterParam[] json)
    {
    }

    [Token(Token = "0x60077EF")]
    [Address(RVA = "0x391E90", Offset = "0x390C90", VA = "0x10391E90")]
    public GuildSearchFilterConditionParam GetConditionsParam(int sval)
    {
      return (GuildSearchFilterConditionParam) null;
    }

    [Token(Token = "0x60077F0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildSearchFilterParam()
    {
    }
  }
}
