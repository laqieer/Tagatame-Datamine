// Decompiled with JetBrains decompiler
// Type: SRPG.EventBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EAF")]
  [AddComponentMenu("Common/EventBanner")]
  public class EventBanner : MonoBehaviour
  {
    [Token(Token = "0x4002D19")]
    [FieldOffset(Offset = "0xC")]
    private RawImage mTarget;
    [Token(Token = "0x4002D1A")]
    [FieldOffset(Offset = "0x10")]
    public float UpdateInterval;
    [Token(Token = "0x4002D1B")]
    [FieldOffset(Offset = "0x14")]
    private float mInterval;
    [Token(Token = "0x4002D1C")]
    [FieldOffset(Offset = "0x18")]
    private string mLastBannerName;
    [Token(Token = "0x4002D1D")]
    [FieldOffset(Offset = "0x1C")]
    private LoadRequest mBannerLoadRequest;

    [Token(Token = "0x6003D1D")]
    [Address(RVA = "0x10F86E0", Offset = "0x10F74E0", VA = "0x110F86E0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003D1E")]
    [Address(RVA = "0x10F8730", Offset = "0x10F7530", VA = "0x110F8730")]
    private void Update()
    {
    }

    [Token(Token = "0x6003D1F")]
    [Address(RVA = "0x10F8B10", Offset = "0x10F7910", VA = "0x110F8B10")]
    public EventBanner()
    {
    }
  }
}
