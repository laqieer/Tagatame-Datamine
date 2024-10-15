// Decompiled with JetBrains decompiler
// Type: SRPG.GvGViewRankingContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002612")]
  [AddComponentMenu("UI/GvG/GvGViewRankingContent")]
  public class GvGViewRankingContent : MonoBehaviour
  {
    [Token(Token = "0x400B145")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray mRankImages;
    [Token(Token = "0x400B146")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mRankText;
    [Token(Token = "0x400B147")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mName;
    [Token(Token = "0x400B148")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mPoint;
    [Token(Token = "0x400B149")]
    private const int RANK_MAX = 3;

    [Token(Token = "0x600A9C0")]
    [Address(RVA = "0x6D00D0", Offset = "0x6CEED0", VA = "0x106D00D0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A9C1")]
    [Address(RVA = "0x6CFE80", Offset = "0x6CEC80", VA = "0x106CFE80")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600A9C2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGViewRankingContent()
    {
    }
  }
}
