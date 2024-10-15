// Decompiled with JetBrains decompiler
// Type: SRPG.UnitStatusPanelGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D04")]
  public class UnitStatusPanelGroup : MonoBehaviour
  {
    [Token(Token = "0x400DFEE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private UnitStatusPanel[] mPanelList;
    [Token(Token = "0x400DFEF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool mIsHideMode;

    [Token(Token = "0x600D199")]
    [Address(RVA = "0x9C9830", Offset = "0x9C8630", VA = "0x109C9830")]
    public void Initialize(UnitData unitdata, bool isHide = false)
    {
    }

    [Token(Token = "0x600D19A")]
    [Address(RVA = "0x9C98A0", Offset = "0x9C86A0", VA = "0x109C98A0")]
    public void Refresh(UnitData unitdata)
    {
    }

    [Token(Token = "0x600D19B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitStatusPanelGroup()
    {
    }
  }
}
