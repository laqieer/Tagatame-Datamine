// Decompiled with JetBrains decompiler
// Type: SRPG.GachaInfoRateWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002432")]
  public class GachaInfoRateWindow : FlowWindowBase
  {
    [Token(Token = "0x400A405")]
    [FieldOffset(Offset = "0x30")]
    private GachaInfoRateWindow.SerializeParam m_Param;
    [Token(Token = "0x400A406")]
    [FieldOffset(Offset = "0x34")]
    private bool m_Destroy;
    [Token(Token = "0x400A407")]
    [FieldOffset(Offset = "0x38")]
    private GachaInfoRateWindow.RateContent.ItemSources m_RateSource;
    [Token(Token = "0x400A408")]
    [FieldOffset(Offset = "0x3C")]
    private ContentController m_RateController;
    [Token(Token = "0x400A409")]
    [FieldOffset(Offset = "0x40")]
    private GachaInfoRateWindow.RateData m_RateData;
    [Token(Token = "0x400A40A")]
    [FieldOffset(Offset = "0x0")]
    private static GachaInfoRateWindow m_Instance;

    [Token(Token = "0x17001615")]
    public static GachaInfoRateWindow instance
    {
      [Token(Token = "0x6009DD4"), Address(RVA = "0x609B40", Offset = "0x608940", VA = "0x10609B40")] get
      {
        return (GachaInfoRateWindow) null;
      }
    }

    [Token(Token = "0x6009DD5")]
    [Address(RVA = "0x609880", Offset = "0x608680", VA = "0x10609880", Slot = "5")]
    public override void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x6009DD6")]
    [Address(RVA = "0x609AE0", Offset = "0x6088E0", VA = "0x10609AE0", Slot = "6")]
    public override void Release()
    {
    }

    [Token(Token = "0x6009DD7")]
    [Address(RVA = "0x4A5B10", Offset = "0x4A4910", VA = "0x104A5B10", Slot = "8")]
    public override int Update() => new int();

    [Token(Token = "0x6009DD8")]
    [Address(RVA = "0x609640", Offset = "0x608440", VA = "0x10609640")]
    public void InitializeRateList()
    {
    }

    [Token(Token = "0x6009DD9")]
    [Address(RVA = "0x609A50", Offset = "0x608850", VA = "0x10609A50")]
    public void ReleaseRateList()
    {
    }

    [Token(Token = "0x6009DDA")]
    [Address(RVA = "0x609A20", Offset = "0x608820", VA = "0x10609A20", Slot = "9")]
    public override int OnActivate(int pinId) => new int();

    [Token(Token = "0x6009DDB")]
    [Address(RVA = "0x6095D0", Offset = "0x6083D0", VA = "0x106095D0")]
    public bool DeserializeRateList(Json_GachaRateParam json) => new bool();

    [Token(Token = "0x6009DDC")]
    [Address(RVA = "0x4A5B50", Offset = "0x4A4950", VA = "0x104A5B50")]
    public GachaInfoRateWindow()
    {
    }

    [Token(Token = "0x2002433")]
    public static class RateContent
    {
      [Token(Token = "0x400A40B")]
      [FieldOffset(Offset = "0x0")]
      public static GachaInfoRateWindow.RateContent.ItemAccessor clickItem;

      [Token(Token = "0x2002434")]
      public class ItemAccessor
      {
        [Token(Token = "0x400A40C")]
        [FieldOffset(Offset = "0x8")]
        private ContentNode m_Node;
        [Token(Token = "0x400A40D")]
        [FieldOffset(Offset = "0xC")]
        private GachaRateParam m_Param;
        [Token(Token = "0x400A40E")]
        [FieldOffset(Offset = "0x10")]
        private DataSource m_DataSource;
        [Token(Token = "0x400A40F")]
        [FieldOffset(Offset = "0x14")]
        private SerializeValueBehaviour m_Value;

        [Token(Token = "0x17001616")]
        public ContentNode node
        {
          [Token(Token = "0x6009DDD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (ContentNode) null;
          }
        }

        [Token(Token = "0x17001617")]
        public GachaRateParam param
        {
          [Token(Token = "0x6009DDE"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (GachaRateParam) null;
          }
        }

        [Token(Token = "0x17001618")]
        public bool IsValid
        {
          [Token(Token = "0x6009DDF"), Address(RVA = "0x2B0090", Offset = "0x2AEE90", VA = "0x102B0090")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x6009DE0")]
        [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
        public void Setup(GachaRateParam param)
        {
        }

        [Token(Token = "0x6009DE1")]
        [Address(RVA = "0x619030", Offset = "0x617E30", VA = "0x10619030")]
        public void Bind(ContentNode node)
        {
        }

        [Token(Token = "0x6009DE2")]
        [Address(RVA = "0x6193C0", Offset = "0x6181C0", VA = "0x106193C0")]
        public void Clear()
        {
        }

        [Token(Token = "0x6009DE3")]
        [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
        public void ForceUpdate()
        {
        }

        [Token(Token = "0x6009DE4")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ItemAccessor()
        {
        }
      }

      [Token(Token = "0x2002435")]
      public class ItemSources : ContentSource
      {
        [Token(Token = "0x400A410")]
        [FieldOffset(Offset = "0x10")]
        private List<GachaInfoRateWindow.RateContent.ItemSources.ItemParam> m_Params;

        [Token(Token = "0x6009DE5")]
        [Address(RVA = "0x6195E0", Offset = "0x6183E0", VA = "0x106195E0", Slot = "4")]
        public override void Initialize(ContentController controller)
        {
        }

        [Token(Token = "0x6009DE6")]
        [Address(RVA = "0x4ADBB0", Offset = "0x4AC9B0", VA = "0x104ADBB0", Slot = "5")]
        public override void Release()
        {
        }

        [Token(Token = "0x6009DE7")]
        [Address(RVA = "0x619570", Offset = "0x618370", VA = "0x10619570")]
        public void Add(
          GachaInfoRateWindow.RateContent.ItemSources.ItemParam param)
        {
        }

        [Token(Token = "0x6009DE8")]
        [Address(RVA = "0x619600", Offset = "0x618400", VA = "0x10619600")]
        public void Setup()
        {
        }

        [Token(Token = "0x6009DE9")]
        [Address(RVA = "0x619830", Offset = "0x618630", VA = "0x10619830")]
        public ItemSources()
        {
        }

        [Token(Token = "0x2002436")]
        public class ItemParam : ContentSource.Param
        {
          [Token(Token = "0x400A411")]
          [FieldOffset(Offset = "0x10")]
          private GachaInfoRateWindow.RateContent.ItemAccessor m_Accessor;

          [Token(Token = "0x17001619")]
          public GachaInfoRateWindow.RateContent.ItemAccessor accessor
          {
            [Token(Token = "0x6009DEA"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
            {
              return (GachaInfoRateWindow.RateContent.ItemAccessor) null;
            }
          }

          [Token(Token = "0x1700161A")]
          public GachaRateParam param
          {
            [Token(Token = "0x6009DEB"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
            {
              return (GachaRateParam) null;
            }
          }

          [Token(Token = "0x6009DEC")]
          [Address(RVA = "0x6194F0", Offset = "0x6182F0", VA = "0x106194F0")]
          public ItemParam(GachaRateParam param)
          {
          }

          [Token(Token = "0x6009DED")]
          [Address(RVA = "0x6194C0", Offset = "0x6182C0", VA = "0x106194C0", Slot = "12")]
          public override void OnEnable(ContentNode node)
          {
          }

          [Token(Token = "0x6009DEE")]
          [Address(RVA = "0x619440", Offset = "0x618240", VA = "0x10619440", Slot = "13")]
          public override void OnDisable(ContentNode node)
          {
          }

          [Token(Token = "0x6009DEF")]
          [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "19")]
          public override void OnClick(ContentNode node)
          {
          }

          [Token(Token = "0x6009DF0")]
          [Address(RVA = "0x605790", Offset = "0x604590", VA = "0x10605790", Slot = "6")]
          public override bool IsValid() => new bool();
        }
      }
    }

    [Token(Token = "0x2002438")]
    public class RateData
    {
      [Token(Token = "0x400A414")]
      [FieldOffset(Offset = "0x8")]
      public GachaRateParam[] rates;
      [Token(Token = "0x400A415")]
      [FieldOffset(Offset = "0xC")]
      private float m_rate_coef;

      [Token(Token = "0x1700161B")]
      public float rate_coef
      {
        [Token(Token = "0x6009DF4"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x6009DF5")]
      [Address(RVA = "0x6198C0", Offset = "0x6186C0", VA = "0x106198C0")]
      public bool Deserialize(Json_GachaRateParam json) => new bool();

      [Token(Token = "0x6009DF6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RateData()
      {
      }
    }

    [Token(Token = "0x200243A")]
    [Serializable]
    public class SerializeParam : FlowWindowBase.SerializeParamBase
    {
      [Token(Token = "0x400A41B")]
      [FieldOffset(Offset = "0xC")]
      public GameObject rateList;

      [Token(Token = "0x1700161C")]
      public override System.Type type
      {
        [Token(Token = "0x6009DFD"), Address(RVA = "0x619ED0", Offset = "0x618CD0", VA = "0x10619ED0", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x6009DFE")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeParam()
      {
      }
    }
  }
}
