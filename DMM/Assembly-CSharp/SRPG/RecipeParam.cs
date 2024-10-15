// Decompiled with JetBrains decompiler
// Type: SRPG.RecipeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CA0")]
  [MessagePackObject(true)]
  public class RecipeParam
  {
    [Token(Token = "0x400707C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400707D")]
    [FieldOffset(Offset = "0xC")]
    public int cost;
    [Token(Token = "0x400707E")]
    [FieldOffset(Offset = "0x10")]
    public RecipeItem[] items;

    [Token(Token = "0x60075F2")]
    [Address(RVA = "0x394E60", Offset = "0x393C60", VA = "0x10394E60")]
    public bool Deserialize(JSON_RecipeParam json) => new bool();

    [Token(Token = "0x60075F3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RecipeParam()
    {
    }
  }
}
