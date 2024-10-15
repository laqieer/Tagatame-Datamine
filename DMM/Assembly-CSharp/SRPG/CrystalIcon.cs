// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002284")]
  public class CrystalIcon : MonoBehaviour
  {
    [Token(Token = "0x400992B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList IconExhibitList;
    [Token(Token = "0x400992C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool IsNoHavingMask;
    [Token(Token = "0x400992D")]
    [FieldOffset(Offset = "0x11")]
    [SerializeField]
    private bool IsRankDisp;
    [Token(Token = "0x400992E")]
    [FieldOffset(Offset = "0x12")]
    [SerializeField]
    private bool IsPlusDisp;
    [Token(Token = "0x400992F")]
    [FieldOffset(Offset = "0x13")]
    [SerializeField]
    private bool IsRankFrame;
    [Token(Token = "0x4009930")]
    [FieldOffset(Offset = "0x14")]
    private CrystalData mData;
    [Token(Token = "0x4009931")]
    [FieldOffset(Offset = "0x18")]
    private CrystalParam mParam;
    [Token(Token = "0x4009932")]
    [FieldOffset(Offset = "0x1C")]
    private CrystalIconModel mIconModel;
    [Token(Token = "0x4009933")]
    [FieldOffset(Offset = "0x20")]
    private float mNowInterval;

    [Token(Token = "0x6009380")]
    [Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")]
    public CrystalData GetData() => (CrystalData) null;

    [Token(Token = "0x6009381")]
    [Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")]
    public CrystalParam GetParam() => (CrystalParam) null;

    [Token(Token = "0x6009382")]
    [Address(RVA = "0x56A020", Offset = "0x568E20", VA = "0x1056A020")]
    public void SetUp(CrystalData _data, CrystalParam _param = null, bool _force_rank_disp = false)
    {
    }

    [Token(Token = "0x6009383")]
    [Address(RVA = "0x569FF0", Offset = "0x568DF0", VA = "0x10569FF0")]
    public void SetForceDispMask(bool is_enable)
    {
    }

    [Token(Token = "0x6009384")]
    [Address(RVA = "0x569F70", Offset = "0x568D70", VA = "0x10569F70")]
    private void Draw()
    {
    }

    [Token(Token = "0x6009385")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalIcon()
    {
    }
  }
}
