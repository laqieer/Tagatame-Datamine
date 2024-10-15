// Decompiled with JetBrains decompiler
// Type: SRPG.SwitchingBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021BF")]
  [AddComponentMenu("UI/Common/SwitchingBadge")]
  public class SwitchingBadge : MonoBehaviour
  {
    [Token(Token = "0x40093F0")]
    private const float CHANGE_INTERBAL = 2f;
    [Token(Token = "0x40093F1")]
    [FieldOffset(Offset = "0xC")]
    protected List<GameObject> m_DispOn;
    [Token(Token = "0x40093F2")]
    [FieldOffset(Offset = "0x10")]
    protected List<GameObject> m_DispOff;
    [Token(Token = "0x40093F3")]
    [FieldOffset(Offset = "0x14")]
    protected int m_Index;
    [Token(Token = "0x40093F4")]
    [FieldOffset(Offset = "0x18")]
    protected float m_Time;

    [Token(Token = "0x17001411")]
    public List<GameObject> DispOn
    {
      [Token(Token = "0x6008E36"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GameObject>) null;
      }
    }

    [Token(Token = "0x6008E37")]
    [Address(RVA = "0x51F3E0", Offset = "0x51E1E0", VA = "0x1051F3E0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008E38")]
    [Address(RVA = "0x51F3E0", Offset = "0x51E1E0", VA = "0x1051F3E0")]
    private void UpdateBadge()
    {
    }

    [Token(Token = "0x6008E39")]
    [Address(RVA = "0x51F1F0", Offset = "0x51DFF0", VA = "0x1051F1F0")]
    protected void UpdateBadgeAlternate(int index)
    {
    }

    [Token(Token = "0x6008E3A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public virtual void Refresh()
    {
    }

    [Token(Token = "0x6008E3B")]
    [Address(RVA = "0x51F140", Offset = "0x51DF40", VA = "0x1051F140")]
    public void Clear()
    {
    }

    [Token(Token = "0x6008E3C")]
    [Address(RVA = "0x51F070", Offset = "0x51DE70", VA = "0x1051F070")]
    public void AddBadgeObject(bool is_disp, GameObject obj)
    {
    }

    [Token(Token = "0x6008E3D")]
    [Address(RVA = "0x51F1D0", Offset = "0x51DFD0", VA = "0x1051F1D0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6008E3E")]
    [Address(RVA = "0x51F480", Offset = "0x51E280", VA = "0x1051F480")]
    public SwitchingBadge()
    {
    }
  }
}
