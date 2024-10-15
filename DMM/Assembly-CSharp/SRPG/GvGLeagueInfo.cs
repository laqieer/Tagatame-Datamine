// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025D3")]
  [FlowNode.Pin(101, "自身のリーグ情報取得", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "リーグの報酬情報表示", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/GvG/GvGLeagueInfo")]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "表示更新", FlowNode.PinTypes.Input, 11)]
  public class GvGLeagueInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AF99")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x400AF9A")]
    private const int PIN_INPUT_REFRESH = 11;
    [Token(Token = "0x400AF9B")]
    private const int PIN_OUTPUT_REWARD_INFO = 100;
    [Token(Token = "0x400AF9C")]
    private const int PIN_OUTPUT_REQUEST = 101;
    [Token(Token = "0x400AF9D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GvGLeagueInfoContent mLeagueInfoTemplate;
    [Token(Token = "0x400AF9E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mHeaderObject;
    [Token(Token = "0x400AF9F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private FlowNode_ReqGvGLeague mRequestNode;
    [Token(Token = "0x400AFA0")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> LeagueList;
    [Token(Token = "0x400AFA1")]
    [FieldOffset(Offset = "0x1C")]
    private List<GvGLeagueParam> m_LeagueParams;

    [Token(Token = "0x600A820")]
    [Address(RVA = "0x6B5FE0", Offset = "0x6B4DE0", VA = "0x106B5FE0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A821")]
    [Address(RVA = "0x6B5830", Offset = "0x6B4630", VA = "0x106B5830", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A822")]
    [Address(RVA = "0x6B5CE0", Offset = "0x6B4AE0", VA = "0x106B5CE0")]
    private void Init()
    {
    }

    [Token(Token = "0x600A823")]
    [Address(RVA = "0x6B5EB0", Offset = "0x6B4CB0", VA = "0x106B5EB0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A824")]
    [Address(RVA = "0x6B5D80", Offset = "0x6B4B80", VA = "0x106B5D80")]
    public void OnClickGvGLeagueReward(GameObject obj)
    {
    }

    [Token(Token = "0x600A825")]
    [Address(RVA = "0x6B5A20", Offset = "0x6B4820", VA = "0x106B5A20")]
    private void CreateLeagueInfo()
    {
    }

    [Token(Token = "0x600A826")]
    [Address(RVA = "0x6B6030", Offset = "0x6B4E30", VA = "0x106B6030")]
    public GvGLeagueInfo()
    {
    }
  }
}
