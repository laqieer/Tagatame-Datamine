// Decompiled with JetBrains decompiler
// Type: SRPG.NetworkIndicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FE1")]
  [AddComponentMenu("Common/NetworkIndicator")]
  public class NetworkIndicator : MonoBehaviour
  {
    [Token(Token = "0x4003824")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Body;
    [Token(Token = "0x4003825")]
    [FieldOffset(Offset = "0x10")]
    public float FadeTime;
    [Token(Token = "0x4003826")]
    [FieldOffset(Offset = "0x14")]
    public float KeepUp;
    [Token(Token = "0x4003827")]
    [FieldOffset(Offset = "0x18")]
    private CanvasGroup mCanvasGroup;
    [Token(Token = "0x4003828")]
    [FieldOffset(Offset = "0x1C")]
    private float mRemainingTime;

    [Token(Token = "0x6004214")]
    [Address(RVA = "0x119A7B0", Offset = "0x11995B0", VA = "0x1119A7B0")]
    private void Start()
    {
    }

    [Token(Token = "0x6004215")]
    [Address(RVA = "0x119A850", Offset = "0x1199650", VA = "0x1119A850")]
    private void Update()
    {
    }

    [Token(Token = "0x6004216")]
    [Address(RVA = "0x119AA50", Offset = "0x1199850", VA = "0x1119AA50")]
    public NetworkIndicator()
    {
    }
  }
}
