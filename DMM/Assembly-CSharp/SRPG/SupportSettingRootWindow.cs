// Decompiled with JetBrains decompiler
// Type: SRPG.SupportSettingRootWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B14")]
  [FlowNode.Pin(101, "No Change", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Is Change Unit", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Refresh", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(100, "Changed", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/SupportSettingRootWindow")]
  public class SupportSettingRootWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D243")]
    private const int INPUT_CHANGE_SUPPORT = 1;
    [Token(Token = "0x400D244")]
    private const int INPUT_REFRESH = 2;
    [Token(Token = "0x400D245")]
    private const int OUTPUT_CHANGE_SUPPORT_SET = 100;
    [Token(Token = "0x400D246")]
    private const int OUTPUT_CHANGE_SUPPORT_NONE = 101;
    [Token(Token = "0x400D247")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SupportElementList m_UnitElementList;
    [Token(Token = "0x400D248")]
    [FieldOffset(Offset = "0x10")]
    private long[] m_UnitUniequeIDs;
    [Token(Token = "0x400D249")]
    [FieldOffset(Offset = "0x14")]
    private long[] m_UnitDefaultUniequeIDs;
    [Token(Token = "0x400D24A")]
    private const int DEFAULT_UNITDATA = 0;

    [Token(Token = "0x600C533")]
    [Address(RVA = "0x8DCD40", Offset = "0x8DBB40", VA = "0x108DCD40")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C534")]
    [Address(RVA = "0x8DD030", Offset = "0x8DBE30", VA = "0x108DD030")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C535")]
    [Address(RVA = "0x8DCD80", Offset = "0x8DBB80", VA = "0x108DCD80")]
    public void Clear()
    {
    }

    [Token(Token = "0x600C536")]
    [Address(RVA = "0x8DD470", Offset = "0x8DC270", VA = "0x108DD470")]
    public void SetSupportUnitData(long[] iids)
    {
    }

    [Token(Token = "0x600C537")]
    [Address(RVA = "0x8DD280", Offset = "0x8DC080", VA = "0x108DD280")]
    public void SetSupportUnitData(UnitData[] units)
    {
    }

    [Token(Token = "0x600C538")]
    [Address(RVA = "0x8DD390", Offset = "0x8DC190", VA = "0x108DD390")]
    public void SetSupportUnitData(int element, long uniqId)
    {
    }

    [Token(Token = "0x600C539")]
    [Address(RVA = "0x8DCE40", Offset = "0x8DBC40", VA = "0x108DCE40")]
    public SupportSettingRootWindow.OwnSupportData[] GetSupportUnitData()
    {
      return (SupportSettingRootWindow.OwnSupportData[]) null;
    }

    [Token(Token = "0x600C53A")]
    [Address(RVA = "0x8DD090", Offset = "0x8DBE90", VA = "0x108DD090")]
    public void OnEvent(string key, string value)
    {
    }

    [Token(Token = "0x600C53B")]
    [Address(RVA = "0x8DCCA0", Offset = "0x8DBAA0", VA = "0x108DCCA0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C53C")]
    [Address(RVA = "0x8DD710", Offset = "0x8DC510", VA = "0x108DD710")]
    public SupportSettingRootWindow()
    {
    }

    [Token(Token = "0x2002B15")]
    public class OwnSupportData
    {
      [Token(Token = "0x400D24B")]
      [FieldOffset(Offset = "0x8")]
      public long m_UniqueID;
      [Token(Token = "0x400D24C")]
      [FieldOffset(Offset = "0x10")]
      public EElement m_Element;

      [Token(Token = "0x600C53D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public OwnSupportData()
      {
      }
    }
  }
}
