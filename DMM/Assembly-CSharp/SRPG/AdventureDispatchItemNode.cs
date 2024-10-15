// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureDispatchItemNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F97")]
  public class AdventureDispatchItemNode : ContentNode
  {
    [Token(Token = "0x400857D")]
    [FieldOffset(Offset = "0x30")]
    private AdventureDispatchItemParam mParam;

    [Token(Token = "0x170012A5")]
    public AdventureDispatchItemParam Param
    {
      [Token(Token = "0x60081CC"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (AdventureDispatchItemParam) null;
      }
    }

    [Token(Token = "0x60081CD")]
    [Address(RVA = "0x420CC0", Offset = "0x41FAC0", VA = "0x10420CC0")]
    public void Setup(AdventureDispatchItemParam param)
    {
    }

    [Token(Token = "0x60081CE")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public AdventureDispatchItemNode()
    {
    }
  }
}
