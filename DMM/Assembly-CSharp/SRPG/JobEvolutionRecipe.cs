// Decompiled with JetBrains decompiler
// Type: SRPG.JobEvolutionRecipe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C1C")]
  public class JobEvolutionRecipe
  {
    [Token(Token = "0x400DA0E")]
    [FieldOffset(Offset = "0x8")]
    public ItemParam Item;
    [Token(Token = "0x400DA0F")]
    [FieldOffset(Offset = "0xC")]
    public RecipeItem RecipeItem;
    [Token(Token = "0x400DA10")]
    [FieldOffset(Offset = "0x10")]
    public int Amount;
    [Token(Token = "0x400DA11")]
    [FieldOffset(Offset = "0x14")]
    public int RequiredAmount;

    [Token(Token = "0x600CC1E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JobEvolutionRecipe()
    {
    }
  }
}
