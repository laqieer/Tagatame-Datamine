// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueRewardList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025E5")]
  [AddComponentMenu("UI/GvG/GvGLeagueRewardList")]
  public class GvGLeagueRewardList : MonoBehaviour
  {
    [Token(Token = "0x400AFFA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRewardAreaRoot;
    [Token(Token = "0x400AFFB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRewardLeagueRoot;
    [Token(Token = "0x400AFFC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRewardAreaTemplate;
    [Token(Token = "0x400AFFD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRewardLeagueTemplate;
    [Token(Token = "0x400AFFE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mAreaTab;
    [Token(Token = "0x400AFFF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mLeagueTab;
    [Token(Token = "0x400B000")]
    [FieldOffset(Offset = "0x24")]
    private GameObject mNowTab;

    [Token(Token = "0x600A87D")]
    [Address(RVA = "0x6B9430", Offset = "0x6B8230", VA = "0x106B9430")]
    private void Start()
    {
    }

    [Token(Token = "0x600A87E")]
    [Address(RVA = "0x6B9350", Offset = "0x6B8150", VA = "0x106B9350")]
    public void SetTab(GameObject obj)
    {
    }

    [Token(Token = "0x600A87F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GvGLeagueRewardList()
    {
    }
  }
}
