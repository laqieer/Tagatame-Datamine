// Decompiled with JetBrains decompiler
// Type: SRPG.UnitBuffDisplayNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BBE")]
  [AddComponentMenu("UI/UnitBuffDisplayNode")]
  public class UnitBuffDisplayNode : MonoBehaviour
  {
    [Token(Token = "0x400D6C7")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Icon;
    [Token(Token = "0x400D6C8")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Arrows;
    [Token(Token = "0x400D6C9")]
    [FieldOffset(Offset = "0x14")]
    private RectTransform m_RectTransform;
    [Token(Token = "0x400D6CA")]
    [FieldOffset(Offset = "0x18")]
    private UnitBuffDisplayNode.DispType m_DispType;
    [Token(Token = "0x400D6CB")]
    [FieldOffset(Offset = "0x1C")]
    private UnitBuffDisplayNode.EffectType m_EffectType;

    [Token(Token = "0x600C924")]
    [Address(RVA = "0x91D6E0", Offset = "0x91C4E0", VA = "0x1091D6E0")]
    private static bool IsNoBuffType(UnitBuffDisplayNode.BuffType buff_type) => new bool();

    [Token(Token = "0x17001A9A")]
    public RectTransform rectTransform
    {
      [Token(Token = "0x600C925"), Address(RVA = "0x91DAC0", Offset = "0x91C8C0", VA = "0x1091DAC0")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x600C926")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C927")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C928")]
    [Address(RVA = "0x91D7D0", Offset = "0x91C5D0", VA = "0x1091D7D0")]
    public void Setup(UnitBuffDisplayNode.Param param)
    {
    }

    [Token(Token = "0x600C929")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Release()
    {
    }

    [Token(Token = "0x600C92A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C92B")]
    [Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")]
    public UnitBuffDisplayNode.DispType GetDispType() => new UnitBuffDisplayNode.DispType();

    [Token(Token = "0x600C92C")]
    [Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")]
    public UnitBuffDisplayNode.EffectType GetEffectType() => new UnitBuffDisplayNode.EffectType();

    [Token(Token = "0x600C92D")]
    [Address(RVA = "0x91D720", Offset = "0x91C520", VA = "0x1091D720")]
    public void SetPos(float x, float y)
    {
    }

    [Token(Token = "0x600C92E")]
    [Address(RVA = "0x91D480", Offset = "0x91C280", VA = "0x1091D480")]
    public static UnitBuffDisplayNode.Param[] CreateParams(
      UnitBuffDisplay parent,
      Unit owner,
      BuffAttachment buff)
    {
      return (UnitBuffDisplayNode.Param[]) null;
    }

    [Token(Token = "0x600C92F")]
    [Address(RVA = "0x91D1B0", Offset = "0x91BFB0", VA = "0x1091D1B0")]
    public static UnitBuffDisplayNode.Param[] CreateOtherParams(UnitBuffDisplay parent, Unit owner)
    {
      return (UnitBuffDisplayNode.Param[]) null;
    }

    [Token(Token = "0x600C930")]
    [Address(RVA = "0x91D620", Offset = "0x91C420", VA = "0x1091D620")]
    public static int GetValue(UnitBuffDisplayNode.BuffType buffType, BuffAttachment buff)
    {
      return new int();
    }

    [Token(Token = "0x600C931")]
    [Address(RVA = "0x91D700", Offset = "0x91C500", VA = "0x1091D700")]
    public static bool NeedDispOn(UnitBuffDisplayNode.Param param) => new bool();

    [Token(Token = "0x600C932")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitBuffDisplayNode()
    {
    }

    [Token(Token = "0x2002BBF")]
    public enum BuffType
    {
      [Token(Token = "0x400D6CD")] NONE,
      [Token(Token = "0x400D6CE")] ATK,
      [Token(Token = "0x400D6CF")] DEF,
      [Token(Token = "0x400D6D0")] MAG,
      [Token(Token = "0x400D6D1")] MND,
      [Token(Token = "0x400D6D2")] FTT,
      [Token(Token = "0x400D6D3")] FTF,
      [Token(Token = "0x400D6D4")] PRT,
      [Token(Token = "0x400D6D5")] GRD,
      [Token(Token = "0x400D6D6")] MAX,
    }

    [Token(Token = "0x2002BC0")]
    public enum DispType
    {
      [Token(Token = "0x400D6D8")] NONE,
      [Token(Token = "0x400D6D9")] ATK,
      [Token(Token = "0x400D6DA")] DEF,
      [Token(Token = "0x400D6DB")] MAG,
      [Token(Token = "0x400D6DC")] MND,
      [Token(Token = "0x400D6DD")] FTT,
      [Token(Token = "0x400D6DE")] FTF,
      [Token(Token = "0x400D6DF")] PRT,
      [Token(Token = "0x400D6E0")] GRD,
    }

    [Token(Token = "0x2002BC1")]
    public enum EffectType
    {
      [Token(Token = "0x400D6E2")] NONE,
      [Token(Token = "0x400D6E3")] UP,
      [Token(Token = "0x400D6E4")] DOWN,
    }

    [Token(Token = "0x2002BC2")]
    public struct Param
    {
      [Token(Token = "0x400D6E5")]
      [FieldOffset(Offset = "0x0")]
      public Unit owner;
      [Token(Token = "0x400D6E6")]
      [FieldOffset(Offset = "0x4")]
      public BuffAttachment buff;
      [Token(Token = "0x400D6E7")]
      [FieldOffset(Offset = "0x8")]
      public UnitBuffDisplay.NodeData data;

      [Token(Token = "0x600C933")]
      [Address(RVA = "0x90C3C0", Offset = "0x90B1C0", VA = "0x1090C3C0")]
      public Param(Unit _owner, BuffAttachment _buff, UnitBuffDisplay.NodeData _data)
      {
      }

      [Token(Token = "0x17001A9B")]
      public bool isAlive
      {
        [Token(Token = "0x600C934"), Address(RVA = "0x90C460", Offset = "0x90B260", VA = "0x1090C460")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001A9C")]
      public bool isNeedDispOn
      {
        [Token(Token = "0x600C935"), Address(RVA = "0x90C570", Offset = "0x90B370", VA = "0x1090C570")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001A9D")]
      public UnitBuffDisplayNode.BuffType buffType
      {
        [Token(Token = "0x600C936"), Address(RVA = "0x90C400", Offset = "0x90B200", VA = "0x1090C400")] get
        {
          return new UnitBuffDisplayNode.BuffType();
        }
      }

      [Token(Token = "0x17001A9E")]
      public UnitBuffDisplayNode.DispType dispType
      {
        [Token(Token = "0x600C937"), Address(RVA = "0x5634B0", Offset = "0x5622B0", VA = "0x105634B0")] get
        {
          return new UnitBuffDisplayNode.DispType();
        }
      }

      [Token(Token = "0x17001A9F")]
      public UnitBuffDisplayNode.EffectType effectType
      {
        [Token(Token = "0x600C938"), Address(RVA = "0x90C420", Offset = "0x90B220", VA = "0x1090C420")] get
        {
          return new UnitBuffDisplayNode.EffectType();
        }
      }

      [Token(Token = "0x17001AA0")]
      public int value
      {
        [Token(Token = "0x600C939"), Address(RVA = "0x90C5C0", Offset = "0x90B3C0", VA = "0x1090C5C0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001AA1")]
      public bool isNoBuffType
      {
        [Token(Token = "0x600C93A"), Address(RVA = "0x90C5A0", Offset = "0x90B3A0", VA = "0x1090C5A0")] get
        {
          return new bool();
        }
      }
    }
  }
}
