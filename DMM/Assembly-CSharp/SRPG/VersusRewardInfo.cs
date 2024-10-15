// Decompiled with JetBrains decompiler
// Type: SRPG.VersusRewardInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002753")]
  [AddComponentMenu("UI/Multi/Versus/VersusRewardInfo")]
  public class VersusRewardInfo : MonoBehaviour
  {
    [Token(Token = "0x400B9A0")]
    [FieldOffset(Offset = "0xC")]
    private readonly float SPACE_SCALE;
    [Token(Token = "0x400B9A1")]
    [FieldOffset(Offset = "0x10")]
    public Toggle arrivedTgl;
    [Token(Token = "0x400B9A2")]
    [FieldOffset(Offset = "0x14")]
    public Toggle seasonTgl;
    [Token(Token = "0x400B9A3")]
    [FieldOffset(Offset = "0x18")]
    public GameObject ArrivalView;
    [Token(Token = "0x400B9A4")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject SeasonView;
    [Token(Token = "0x400B9A5")]
    [FieldOffset(Offset = "0x20")]
    public ScrollRect Scroll;
    [Token(Token = "0x400B9A6")]
    [FieldOffset(Offset = "0x24")]
    public RectTransform ListParent;

    [Token(Token = "0x600B076")]
    [Address(RVA = "0x751290", Offset = "0x750090", VA = "0x10751290")]
    private void Start()
    {
    }

    [Token(Token = "0x600B077")]
    [Address(RVA = "0x750CC0", Offset = "0x74FAC0", VA = "0x10750CC0")]
    public void OnChangeArrival(bool flg)
    {
    }

    [Token(Token = "0x600B078")]
    [Address(RVA = "0x750F40", Offset = "0x74FD40", VA = "0x10750F40")]
    public void OnChangeSeason(bool flg)
    {
    }

    [Token(Token = "0x600B079")]
    [Address(RVA = "0x7511C0", Offset = "0x74FFC0", VA = "0x107511C0")]
    private void SetScrollRect(RectTransform rect)
    {
    }

    [Token(Token = "0x600B07A")]
    [Address(RVA = "0x751430", Offset = "0x750230", VA = "0x10751430")]
    public VersusRewardInfo()
    {
    }
  }
}
