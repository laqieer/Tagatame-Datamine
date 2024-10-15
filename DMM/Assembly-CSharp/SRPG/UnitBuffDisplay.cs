// Decompiled with JetBrains decompiler
// Type: SRPG.UnitBuffDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BBA")]
  [AddComponentMenu("UI/UnitBuffDisplay")]
  public class UnitBuffDisplay : MonoBehaviour
  {
    [Token(Token = "0x400D6B3")]
    [FieldOffset(Offset = "0x0")]
    private static float DISP_TIME;
    [Token(Token = "0x400D6B4")]
    [FieldOffset(Offset = "0xC")]
    public UnitBuffDisplay.NodeData[] m_NodeData;
    [Token(Token = "0x400D6B5")]
    [FieldOffset(Offset = "0x10")]
    public GameObject m_Root;
    [Token(Token = "0x400D6B6")]
    [FieldOffset(Offset = "0x14")]
    public UnitBuffDisplayNode m_NodeRoot;
    [Token(Token = "0x400D6B7")]
    [FieldOffset(Offset = "0x18")]
    private Unit m_Owner;
    [Token(Token = "0x400D6B8")]
    [FieldOffset(Offset = "0x1C")]
    private List<UnitBuffDisplay.Object> m_Objects;
    [Token(Token = "0x400D6B9")]
    [FieldOffset(Offset = "0x20")]
    private List<UnitBuffDisplay.Object> m_DispObjects;
    [Token(Token = "0x400D6BA")]
    [FieldOffset(Offset = "0x24")]
    private float m_Time;
    [Token(Token = "0x400D6BB")]
    [FieldOffset(Offset = "0x28")]
    private UnitBuffDisplay.Object m_CurrentObject;

    [Token(Token = "0x17001A97")]
    public UnitBuffDisplay.Object[] objects
    {
      [Token(Token = "0x600C907"), Address(RVA = "0x91EA40", Offset = "0x91D840", VA = "0x1091EA40")] get
      {
        return (UnitBuffDisplay.Object[]) null;
      }
    }

    [Token(Token = "0x600C908")]
    [Address(RVA = "0x91DB40", Offset = "0x91C940", VA = "0x1091DB40")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C909")]
    [Address(RVA = "0x91E430", Offset = "0x91D230", VA = "0x1091E430")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600C90A")]
    [Address(RVA = "0x91DEF0", Offset = "0x91CCF0", VA = "0x1091DEF0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C90B")]
    [Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")]
    private void Initiallize(Unit owner)
    {
    }

    [Token(Token = "0x600C90C")]
    [Address(RVA = "0x91DEF0", Offset = "0x91CCF0", VA = "0x1091DEF0")]
    private void Release()
    {
    }

    [Token(Token = "0x600C90D")]
    [Address(RVA = "0x91E810", Offset = "0x91D610", VA = "0x1091E810")]
    private void Update()
    {
    }

    [Token(Token = "0x600C90E")]
    [Address(RVA = "0x91E0C0", Offset = "0x91CEC0", VA = "0x1091E0C0")]
    private void RequestBuff()
    {
    }

    [Token(Token = "0x600C90F")]
    [Address(RVA = "0x91E4A0", Offset = "0x91D2A0", VA = "0x1091E4A0")]
    private void UpdateBuff()
    {
    }

    [Token(Token = "0x600C910")]
    [Address(RVA = "0x91E6C0", Offset = "0x91D4C0", VA = "0x1091E6C0")]
    private void UpdateNodeDisp()
    {
    }

    [Token(Token = "0x600C911")]
    [Address(RVA = "0x91DDE0", Offset = "0x91CBE0", VA = "0x1091DDE0")]
    private UnitBuffDisplay.Object GetObject(BuffAttachment buff) => (UnitBuffDisplay.Object) null;

    [Token(Token = "0x600C912")]
    [Address(RVA = "0x91DBC0", Offset = "0x91C9C0", VA = "0x1091DBC0")]
    private void CreateNode(UnitBuffDisplay.Object obj)
    {
    }

    [Token(Token = "0x600C913")]
    [Address(RVA = "0x91E000", Offset = "0x91CE00", VA = "0x1091E000")]
    private void RemoveNode(UnitBuffDisplay.Object obj)
    {
    }

    [Token(Token = "0x600C914")]
    [Address(RVA = "0x91DD80", Offset = "0x91CB80", VA = "0x1091DD80")]
    public UnitBuffDisplay.NodeData GetNodeData(UnitBuffDisplayNode.BuffType buffType)
    {
      return (UnitBuffDisplay.NodeData) null;
    }

    [Token(Token = "0x600C915")]
    [Address(RVA = "0x91DFF0", Offset = "0x91CDF0", VA = "0x1091DFF0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600C916")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600C917")]
    [Address(RVA = "0x91E9A0", Offset = "0x91D7A0", VA = "0x1091E9A0")]
    public UnitBuffDisplay()
    {
    }

    [Token(Token = "0x600C918")]
    [Address(RVA = "0x91E970", Offset = "0x91D770", VA = "0x1091E970")]
    static UnitBuffDisplay()
    {
    }

    [Token(Token = "0x2002BBB")]
    [Serializable]
    public class NodeData
    {
      [Token(Token = "0x400D6BC")]
      [FieldOffset(Offset = "0x8")]
      public UnitBuffDisplayNode.BuffType buff;
      [Token(Token = "0x400D6BD")]
      [FieldOffset(Offset = "0xC")]
      public UnitBuffDisplayNode.DispType disp;
      [Token(Token = "0x400D6BE")]
      [FieldOffset(Offset = "0x10")]
      public Sprite sprite;

      [Token(Token = "0x600C919")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public NodeData()
      {
      }
    }

    [Token(Token = "0x2002BBC")]
    public class Object
    {
      [Token(Token = "0x400D6BF")]
      [FieldOffset(Offset = "0x8")]
      public List<UnitBuffDisplayNode.Param> paramlist;
      [Token(Token = "0x400D6C0")]
      [FieldOffset(Offset = "0xC")]
      public UnitBuffDisplayNode.DispType dispType;
      [Token(Token = "0x400D6C1")]
      [FieldOffset(Offset = "0x10")]
      public UnitBuffDisplayNode.EffectType effectType;
      [Token(Token = "0x400D6C2")]
      [FieldOffset(Offset = "0x14")]
      public UnitBuffDisplayNode node;

      [Token(Token = "0x600C91A")]
      [Address(RVA = "0x90C2B0", Offset = "0x90B0B0", VA = "0x1090C2B0")]
      public Object(UnitBuffDisplayNode.Param param)
      {
      }

      [Token(Token = "0x600C91B")]
      [Address(RVA = "0x90C190", Offset = "0x90AF90", VA = "0x1090C190")]
      public void Add(UnitBuffDisplayNode.Param param)
      {
      }

      [Token(Token = "0x600C91C")]
      [Address(RVA = "0x90C250", Offset = "0x90B050", VA = "0x1090C250")]
      public void Remove(UnitBuffDisplayNode.Param param)
      {
      }

      [Token(Token = "0x600C91D")]
      [Address(RVA = "0x90C1F0", Offset = "0x90AFF0", VA = "0x1090C1F0")]
      public bool IsEqual(UnitBuffDisplayNode.Param param) => new bool();
    }
  }
}
