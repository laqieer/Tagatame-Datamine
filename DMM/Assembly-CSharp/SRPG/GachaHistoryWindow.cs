// Decompiled with JetBrains decompiler
// Type: SRPG.GachaHistoryWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002431")]
  [AddComponentMenu("UI/GachaHistoryWindow")]
  [FlowNode.Pin(1, "Setup", FlowNode.PinTypes.Input, 1)]
  public class GachaHistoryWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A3FB")]
    private const int PIN_IN_SETUP = 1;
    [Token(Token = "0x400A3FC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Cauntion;
    [Token(Token = "0x400A3FD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400A3FE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject NodeTemplate;
    [Token(Token = "0x400A3FF")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int NODE_VIEW_MAX;
    [Token(Token = "0x400A400")]
    [FieldOffset(Offset = "0x18")]
    private string mTitleName;
    [Token(Token = "0x400A401")]
    [FieldOffset(Offset = "0x20")]
    private long mDropAt;
    [Token(Token = "0x400A402")]
    [FieldOffset(Offset = "0x28")]
    private List<GachaHistoryData[]> mHistorySets;
    [Token(Token = "0x400A403")]
    [FieldOffset(Offset = "0x2C")]
    private List<GachaHistoryData> mCacheHistorys;
    [Token(Token = "0x400A404")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> mListObjects;

    [Token(Token = "0x6009DCE")]
    [Address(RVA = "0x608E00", Offset = "0x607C00", VA = "0x10608E00", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009DCF")]
    [Address(RVA = "0x609410", Offset = "0x608210", VA = "0x10609410")]
    private void Start()
    {
    }

    [Token(Token = "0x6009DD0")]
    [Address(RVA = "0x608E20", Offset = "0x607C20", VA = "0x10608E20")]
    public bool SetGachaHistoryData(Json_GachaHistoryLog historys) => new bool();

    [Token(Token = "0x6009DD1")]
    [Address(RVA = "0x609140", Offset = "0x607F40", VA = "0x10609140")]
    private void Setup()
    {
    }

    [Token(Token = "0x6009DD2")]
    [Address(RVA = "0x6094D0", Offset = "0x6082D0", VA = "0x106094D0")]
    public GachaHistoryWindow()
    {
    }

    [Token(Token = "0x6009DD3")]
    [Address(RVA = "0x6094A0", Offset = "0x6082A0", VA = "0x106094A0")]
    static GachaHistoryWindow()
    {
    }
  }
}
