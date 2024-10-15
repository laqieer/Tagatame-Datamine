// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureDispatchItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F96")]
  public class AdventureDispatchItemParam : ContentSource.Param
  {
    [Token(Token = "0x400857A")]
    [FieldOffset(Offset = "0x10")]
    public AdventureData Data;
    [Token(Token = "0x400857B")]
    [FieldOffset(Offset = "0x14")]
    public AdventureDispatchBundle Window;
    [Token(Token = "0x400857C")]
    [FieldOffset(Offset = "0x18")]
    private AdventureDispatchItemNode mNode;

    [Token(Token = "0x60081C8")]
    [Address(RVA = "0x420DD0", Offset = "0x41FBD0", VA = "0x10420DD0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x60081C9")]
    [Address(RVA = "0x41BDD0", Offset = "0x41ABD0", VA = "0x1041BDD0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x60081CA")]
    [Address(RVA = "0x420E90", Offset = "0x41FC90", VA = "0x10420E90")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60081CB")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public AdventureDispatchItemParam()
    {
    }
  }
}
