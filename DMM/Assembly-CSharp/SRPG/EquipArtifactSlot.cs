// Decompiled with JetBrains decompiler
// Type: SRPG.EquipArtifactSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002353")]
  [AddComponentMenu("UI/EquipArtifactSlot")]
  public class EquipArtifactSlot : GenericSlot
  {
    [Token(Token = "0x4009E49")]
    [FieldOffset(Offset = "0x24")]
    public SRPG_Button Lock;

    [Token(Token = "0x6009847")]
    [Address(RVA = "0x5B0400", Offset = "0x5AF200", VA = "0x105B0400")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009848")]
    [Address(RVA = "0x51C890", Offset = "0x51B690", VA = "0x1051C890")]
    private void OnButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x6009849")]
    [Address(RVA = "0x51C8D0", Offset = "0x51B6D0", VA = "0x1051C8D0")]
    private void OnLockClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600984A")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public EquipArtifactSlot()
    {
    }
  }
}
