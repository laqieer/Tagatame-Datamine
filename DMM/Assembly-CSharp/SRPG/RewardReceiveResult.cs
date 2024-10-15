// Decompiled with JetBrains decompiler
// Type: SRPG.RewardReceiveResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002950")]
  [AddComponentMenu("UI/RewardReceiveResult")]
  [FlowNode.Pin(101, "Error", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  public class RewardReceiveResult : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C712")]
    public const string SVB_KEY_REWARD_DATA = "SVB_KEY_REWARD_DATA";
    [Token(Token = "0x400C713")]
    public const string SVB_KEY_TITLE_TEXT = "SVB_KEY_TITLE_TEXT";
    [Token(Token = "0x400C714")]
    public const int PIN_IN_INIT = 1;
    [Token(Token = "0x400C715")]
    public const int PIN_OUT_ERROR = 101;
    [Token(Token = "0x400C716")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour mSvb;
    [Token(Token = "0x400C717")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentExhibit mContentExhibit;
    [Token(Token = "0x400C718")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mTitleText;
    [Token(Token = "0x400C719")]
    [FieldOffset(Offset = "0x18")]
    private List<RewardReceiveResultModel> mModels;
    [Token(Token = "0x400C71A")]
    [FieldOffset(Offset = "0x0")]
    private static List<RewardReceiveResult.ReceiveData> mReceiveDatas;
    [Token(Token = "0x400C71B")]
    [FieldOffset(Offset = "0x4")]
    private static string mTitle;

    [Token(Token = "0x600BADE")]
    [Address(RVA = "0x8269D0", Offset = "0x8257D0", VA = "0x108269D0")]
    public static void SetData(
      List<RewardReceiveResult.ReceiveData> receive_datas,
      string title_text)
    {
    }

    [Token(Token = "0x600BADF")]
    [Address(RVA = "0x826970", Offset = "0x825770", VA = "0x10826970")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x600BAE0")]
    [Address(RVA = "0x826270", Offset = "0x825070", VA = "0x10826270", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BAE1")]
    [Address(RVA = "0x826290", Offset = "0x825090", VA = "0x10826290")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600BAE2")]
    [Address(RVA = "0x8266C0", Offset = "0x8254C0", VA = "0x108266C0")]
    private void MoldRewardData()
    {
    }

    [Token(Token = "0x600BAE3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RewardReceiveResult()
    {
    }

    [Token(Token = "0x2002951")]
    public class ReceiveData
    {
      [Token(Token = "0x400C71C")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400C71D")]
      [FieldOffset(Offset = "0xC")]
      public int type;
      [Token(Token = "0x400C71E")]
      [FieldOffset(Offset = "0x10")]
      public int num;

      [Token(Token = "0x600BAE4")]
      [Address(RVA = "0x81B760", Offset = "0x81A560", VA = "0x1081B760")]
      public ReceiveData()
      {
      }
    }
  }
}
