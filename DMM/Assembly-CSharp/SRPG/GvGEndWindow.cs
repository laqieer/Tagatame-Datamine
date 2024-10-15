// Decompiled with JetBrains decompiler
// Type: SRPG.GvGEndWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025CE")]
  [AddComponentMenu("UI/GvG/GvGEndWindow")]
  public class GvGEndWindow : MonoBehaviour
  {
    [Token(Token = "0x400AF78")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GvGEndWindow.eGvGEndResultType mResultType;
    [Token(Token = "0x400AF79")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mRankText;
    [Token(Token = "0x400AF7A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mPointText;
    [Token(Token = "0x400AF7B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mCaptureNodeCountText;

    [Token(Token = "0x600A809")]
    [Address(RVA = "0x6B35F0", Offset = "0x6B23F0", VA = "0x106B35F0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A80A")]
    [Address(RVA = "0x6B36A0", Offset = "0x6B24A0", VA = "0x106B36A0")]
    private void Init()
    {
    }

    [Token(Token = "0x600A80B")]
    [Address(RVA = "0x6B38A0", Offset = "0x6B26A0", VA = "0x106B38A0")]
    private void Setup(GvGResultData result_data)
    {
    }

    [Token(Token = "0x600A80C")]
    [Address(RVA = "0x6B3600", Offset = "0x6B2400", VA = "0x106B3600")]
    private GvGResultData GetResultData(GvGEndWindow.eGvGEndResultType result_type)
    {
      return (GvGResultData) null;
    }

    [Token(Token = "0x600A80D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGEndWindow()
    {
    }

    [Token(Token = "0x20025CF")]
    public enum eGvGEndResultType
    {
      [Token(Token = "0x400AF7D")] None,
      [Token(Token = "0x400AF7E")] Daily,
      [Token(Token = "0x400AF7F")] Season,
    }
  }
}
