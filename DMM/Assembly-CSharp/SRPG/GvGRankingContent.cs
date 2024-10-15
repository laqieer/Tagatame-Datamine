// Decompiled with JetBrains decompiler
// Type: SRPG.GvGRankingContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200260D")]
  [AddComponentMenu("UI/GvG/GvGRankingContent")]
  public class GvGRankingContent : MonoBehaviour
  {
    [Token(Token = "0x400B121")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private int DRAW_STRING_UNDER_RANK;
    [Token(Token = "0x400B122")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray mRankImages;
    [Token(Token = "0x400B123")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mRankText;
    [Token(Token = "0x400B124")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mScoreText;

    [Token(Token = "0x600A9A6")]
    [Address(RVA = "0x6CEA50", Offset = "0x6CD850", VA = "0x106CEA50")]
    public void Setup(GvGRankingGuildData guild)
    {
    }

    [Token(Token = "0x600A9A7")]
    [Address(RVA = "0x6CEC40", Offset = "0x6CDA40", VA = "0x106CEC40")]
    public GvGRankingContent()
    {
    }
  }
}
