// Decompiled with JetBrains decompiler
// Type: SRPG.GvGInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025D1")]
  [AddComponentMenu("UI/GvG/GvGInfo")]
  public class GvGInfo : MonoBehaviour
  {
    [Token(Token = "0x400AF89")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mPhaseText;
    [Token(Token = "0x400AF8A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mNextText;
    [Token(Token = "0x400AF8B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button mUpdateButton;
    [Token(Token = "0x400AF8C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRestUnitCountRoot;
    [Token(Token = "0x400AF8D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mRankingRoot;
    [Token(Token = "0x400AF8E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mRankingTemplate;
    [Token(Token = "0x400AF8F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mCoolTimeRankingRoot;
    [Token(Token = "0x400AF90")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mCoolTimeRankingTemplate;
    [Token(Token = "0x400AF91")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private bool isRankingDraw;
    [Token(Token = "0x400AF92")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> coolTimeTempList;
    [Token(Token = "0x400AF93")]
    [FieldOffset(Offset = "0x38")]
    private DateTime mEndTime;
    [Token(Token = "0x400AF94")]
    [FieldOffset(Offset = "0x40")]
    private DateTime mElapsedTime;
    [Token(Token = "0x400AF95")]
    [FieldOffset(Offset = "0x48")]
    private List<GameObject> mRankingList;

    [Token(Token = "0x600A813")]
    [Address(RVA = "0x6B3A10", Offset = "0x6B2810", VA = "0x106B3A10")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A814")]
    [Address(RVA = "0x6B4B50", Offset = "0x6B3950", VA = "0x106B4B50")]
    private void Start()
    {
    }

    [Token(Token = "0x600A815")]
    [Address(RVA = "0x6B3AC0", Offset = "0x6B28C0", VA = "0x106B3AC0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600A816")]
    [Address(RVA = "0x6B3A20", Offset = "0x6B2820", VA = "0x106B3A20")]
    public void OnChangeRankingDraw()
    {
    }

    [Token(Token = "0x600A817")]
    [Address(RVA = "0x6B4BD0", Offset = "0x6B39D0", VA = "0x106B4BD0")]
    public void UpdateGameParameter()
    {
    }

    [Token(Token = "0x600A818")]
    [Address(RVA = "0x6B4060", Offset = "0x6B2E60", VA = "0x106B4060")]
    public static DateTime SetNextPhaseTime(Text phaseText, Text nextText) => new DateTime();

    [Token(Token = "0x600A819")]
    [Address(RVA = "0x6B4C70", Offset = "0x6B3A70", VA = "0x106B4C70")]
    private void Update()
    {
    }

    [Token(Token = "0x600A81A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A81B")]
    [Address(RVA = "0x6B4FC0", Offset = "0x6B3DC0", VA = "0x106B4FC0")]
    public GvGInfo()
    {
    }
  }
}
