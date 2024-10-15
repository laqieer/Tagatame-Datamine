// Decompiled with JetBrains decompiler
// Type: SRPG.SortRuneParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D4F")]
  public class SortRuneParam
  {
    [Token(Token = "0x4007353")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007354")]
    [FieldOffset(Offset = "0xC")]
    public string tab_name;
    [Token(Token = "0x4007355")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4007356")]
    [FieldOffset(Offset = "0x14")]
    public SortRuneConditionParam[] conditions;

    [Token(Token = "0x6007810")]
    [Address(RVA = "0x39FF70", Offset = "0x39ED70", VA = "0x1039FF70")]
    public void Deserialize(JSON_SortRuneParam json)
    {
    }

    [Token(Token = "0x6007811")]
    [Address(RVA = "0x3A0110", Offset = "0x39EF10", VA = "0x103A0110")]
    public static void Deserialize(ref SortRuneParam[] param, JSON_SortRuneParam[] json)
    {
    }

    [Token(Token = "0x6007812")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SortRuneParam()
    {
    }
  }
}
