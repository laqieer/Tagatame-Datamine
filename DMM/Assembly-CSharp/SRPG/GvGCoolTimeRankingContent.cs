// Decompiled with JetBrains decompiler
// Type: SRPG.GvGCoolTimeRankingContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025A2")]
  [AddComponentMenu("UI/GvG/GvGCoolTimeRankingContent")]
  public class GvGCoolTimeRankingContent : MonoBehaviour
  {
    [Token(Token = "0x400AEC3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mName;
    [Token(Token = "0x400AEC4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mPoint;
    [Token(Token = "0x400AEC5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Image mColor;
    [Token(Token = "0x400AEC6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image mIcon;

    [Token(Token = "0x600A748")]
    [Address(RVA = "0x691880", Offset = "0x690680", VA = "0x10691880")]
    private void Start()
    {
    }

    [Token(Token = "0x600A749")]
    [Address(RVA = "0x691520", Offset = "0x690320", VA = "0x10691520")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600A74A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGCoolTimeRankingContent()
    {
    }
  }
}
