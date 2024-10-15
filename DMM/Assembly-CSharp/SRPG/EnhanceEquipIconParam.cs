// Decompiled with JetBrains decompiler
// Type: SRPG.EnhanceEquipIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002351")]
  public class EnhanceEquipIconParam : ContentSource.Param
  {
    [Token(Token = "0x4009E44")]
    [FieldOffset(Offset = "0x10")]
    public EnhanceMaterial mEnhanceMaterial;
    [Token(Token = "0x4009E45")]
    [FieldOffset(Offset = "0x14")]
    public bool IsEmpty;
    [Token(Token = "0x4009E46")]
    [FieldOffset(Offset = "0x18")]
    private EnhanceEquipIconNode mNode;

    [Token(Token = "0x6009840")]
    [Address(RVA = "0x5AFC70", Offset = "0x5AEA70", VA = "0x105AFC70", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x6009841")]
    [Address(RVA = "0x492EB0", Offset = "0x491CB0", VA = "0x10492EB0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x6009842")]
    [Address(RVA = "0x5AFD30", Offset = "0x5AEB30", VA = "0x105AFD30")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6009843")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public EnhanceEquipIconParam()
    {
    }
  }
}
