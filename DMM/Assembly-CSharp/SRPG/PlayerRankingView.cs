// Decompiled with JetBrains decompiler
// Type: SRPG.PlayerRankingView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002909")]
  [FlowNode.Pin(101, "ポート情報を取得", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "プレイヤー情報を取得", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/CombatPower/PlayerRankingView")]
  public class PlayerRankingView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400C5AF")]
    private const int PIN_OUTPUT_OPEN_PLAYER_INFO = 100;
    [Token(Token = "0x400C5B0")]
    private const int PIN_OUTPUT_OPEN_PORT_INFO = 101;
    [Token(Token = "0x400C5B1")]
    private const string UNIT_MODEL_INFO = "UNIT_MODEL_INFO";
    [Token(Token = "0x400C5B2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour mSerializeValueBehaviour;

    [Token(Token = "0x600B9C9")]
    [Address(RVA = "0x8056F0", Offset = "0x8044F0", VA = "0x108056F0")]
    public void SetUp(PlayerRankingModel _model)
    {
    }

    [Token(Token = "0x600B9CA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600B9CB")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B9CC")]
    [Address(RVA = "0x8054C0", Offset = "0x8042C0", VA = "0x108054C0")]
    public void OnClickPlayerDetail()
    {
    }

    [Token(Token = "0x600B9CD")]
    [Address(RVA = "0x8055C0", Offset = "0x8043C0", VA = "0x108055C0")]
    public void OnClickPortDetail()
    {
    }

    [Token(Token = "0x600B9CE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PlayerRankingView()
    {
    }
  }
}
