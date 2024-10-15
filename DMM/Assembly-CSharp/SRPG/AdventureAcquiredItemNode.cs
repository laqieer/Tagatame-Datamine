// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureAcquiredItemNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F67")]
  public class AdventureAcquiredItemNode : ContentNode
  {
    [Token(Token = "0x400846F")]
    [FieldOffset(Offset = "0x30")]
    private AdventureAcquiredItemParam mParam;

    [Token(Token = "0x17001276")]
    public AdventureAcquiredItemParam Param
    {
      [Token(Token = "0x60080DF"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (AdventureAcquiredItemParam) null;
      }
    }

    [Token(Token = "0x60080E0")]
    [Address(RVA = "0x418000", Offset = "0x416E00", VA = "0x10418000")]
    public void Setup(AdventureAcquiredItemParam param)
    {
    }

    [Token(Token = "0x60080E1")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public AdventureAcquiredItemNode()
    {
    }
  }
}
