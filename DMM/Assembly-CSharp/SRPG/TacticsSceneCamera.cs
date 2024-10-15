// Decompiled with JetBrains decompiler
// Type: SRPG.TacticsSceneCamera
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
  [Token(Token = "0x2000DBA")]
  [AddComponentMenu("Battle/TacticsSceneCamera")]
  public class TacticsSceneCamera : MonoBehaviour
  {
    [Token(Token = "0x40027E7")]
    [FieldOffset(Offset = "0xC")]
    public TacticsSceneCamera.MoveRange m_MoveRange;
    [Token(Token = "0x40027E8")]
    [FieldOffset(Offset = "0x10")]
    public TacticsSceneCamera.AllRange m_AllRange;
    [Token(Token = "0x40027E9")]
    [FieldOffset(Offset = "0x14")]
    private TacticsSceneCamera.AllRangeObj m_AllRangeObj;
    [Token(Token = "0x40027EA")]
    [FieldOffset(Offset = "0x0")]
    private static TacticsSceneCamera m_Instance;

    [Token(Token = "0x170003C9")]
    public TacticsSceneCamera.MoveRange moveRange
    {
      [Token(Token = "0x6003770"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (TacticsSceneCamera.MoveRange) null;
      }
    }

    [Token(Token = "0x170003CA")]
    public TacticsSceneCamera.AllRange allRange
    {
      [Token(Token = "0x6003771"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (TacticsSceneCamera.AllRange) null;
      }
    }

    [Token(Token = "0x170003CB")]
    public bool isAllRange
    {
      [Token(Token = "0x6003772"), Address(RVA = "0x10ADBF0", Offset = "0x10AC9F0", VA = "0x110ADBF0")] set
      {
      }
      [Token(Token = "0x6003773"), Address(RVA = "0x9E3440", Offset = "0x9E2240", VA = "0x109E3440")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170003CC")]
    public static TacticsSceneCamera instance
    {
      [Token(Token = "0x6003774"), Address(RVA = "0x10ADBC0", Offset = "0x10AC9C0", VA = "0x110ADBC0")] get
      {
        return (TacticsSceneCamera) null;
      }
    }

    [Token(Token = "0x6003775")]
    [Address(RVA = "0x10AD0F0", Offset = "0x10ABEF0", VA = "0x110AD0F0")]
    public static void ClearInstance()
    {
    }

    [Token(Token = "0x6003776")]
    [Address(RVA = "0x10AD950", Offset = "0x10AC750", VA = "0x110AD950")]
    private void Start()
    {
    }

    [Token(Token = "0x6003777")]
    [Address(RVA = "0x10ADB90", Offset = "0x10AC990", VA = "0x110ADB90")]
    private void Update()
    {
    }

    [Token(Token = "0x6003778")]
    [Address(RVA = "0x10AD9E0", Offset = "0x10AC7E0", VA = "0x110AD9E0")]
    private void UpdateAllRangeCamera()
    {
    }

    [Token(Token = "0x6003779")]
    [Address(RVA = "0x10ACE70", Offset = "0x10ABC70", VA = "0x110ACE70")]
    private void CalcAllRangeCamera()
    {
    }

    [Token(Token = "0x600377A")]
    [Address(RVA = "0x10AD190", Offset = "0x10ABF90", VA = "0x110AD190")]
    public void CreateMoveRange(TacticsSceneSettings setting)
    {
    }

    [Token(Token = "0x600377B")]
    [Address(RVA = "0x10AD130", Offset = "0x10ABF30", VA = "0x110AD130")]
    public void CreateAllRange()
    {
    }

    [Token(Token = "0x600377C")]
    [Address(RVA = "0x10AD850", Offset = "0x10AC650", VA = "0x110AD850")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600377D")]
    [Address(RVA = "0x10AD810", Offset = "0x10AC610", VA = "0x110AD810")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600377E")]
    [Address(RVA = "0x10AD740", Offset = "0x10AC540", VA = "0x110AD740")]
    public static TacticsSceneCamera.RenderSet[] GetRenderSets(GameObject[] gobjs, string[] shaders)
    {
      return (TacticsSceneCamera.RenderSet[]) null;
    }

    [Token(Token = "0x600377F")]
    [Address(RVA = "0x10AD240", Offset = "0x10AC040", VA = "0x110AD240")]
    public static TacticsSceneCamera.RenderSet GetRenderSet(GameObject gobj, string[] shaders)
    {
      return (TacticsSceneCamera.RenderSet) null;
    }

    [Token(Token = "0x6003780")]
    [Address(RVA = "0x10AD070", Offset = "0x10ABE70", VA = "0x110AD070")]
    private static bool CheckMaterialShader(Material material, string[] shaders) => new bool();

    [Token(Token = "0x6003781")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TacticsSceneCamera()
    {
    }

    [Token(Token = "0x2000DBB")]
    [Serializable]
    public class MoveRange
    {
      [Token(Token = "0x40027EB")]
      [FieldOffset(Offset = "0x8")]
      public bool isOverride;
      [Token(Token = "0x40027EC")]
      [FieldOffset(Offset = "0xC")]
      public float min;
      [Token(Token = "0x40027ED")]
      [FieldOffset(Offset = "0x10")]
      public float max;
      [Token(Token = "0x40027EE")]
      [FieldOffset(Offset = "0x14")]
      public float start;

      [Token(Token = "0x6003782")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public MoveRange()
      {
      }
    }

    [Token(Token = "0x2000DBC")]
    [Serializable]
    public class AllRange
    {
      [Token(Token = "0x40027EF")]
      [FieldOffset(Offset = "0x8")]
      public bool enable;
      [Token(Token = "0x40027F0")]
      [FieldOffset(Offset = "0xC")]
      public TacticsSceneCamera.AllRange.Group[] groups;

      [Token(Token = "0x6003783")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public AllRange()
      {
      }

      [Token(Token = "0x2000DBD")]
      [Serializable]
      public class Group
      {
        [Token(Token = "0x40027F1")]
        [FieldOffset(Offset = "0x8")]
        public string name;
        [Token(Token = "0x40027F2")]
        [FieldOffset(Offset = "0xC")]
        public float min;
        [Token(Token = "0x40027F3")]
        [FieldOffset(Offset = "0x10")]
        public float max;
        [Token(Token = "0x40027F4")]
        [FieldOffset(Offset = "0x14")]
        public float prange;
        [Token(Token = "0x40027F5")]
        [FieldOffset(Offset = "0x18")]
        public bool fade;
        [Token(Token = "0x40027F6")]
        [FieldOffset(Offset = "0x1C")]
        public GameObject[] gobjs;

        [Token(Token = "0x6003784")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Group()
        {
        }
      }
    }

    [Token(Token = "0x2000DBE")]
    public class AllRangeObj
    {
      [Token(Token = "0x40027F7")]
      [FieldOffset(Offset = "0x8")]
      public TacticsSceneCamera.AllRange data;
      [Token(Token = "0x40027F8")]
      [FieldOffset(Offset = "0xC")]
      public TacticsSceneCamera.AllRangeObj.GroupObj[] groups;

      [Token(Token = "0x6003785")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public AllRangeObj()
      {
      }

      [Token(Token = "0x2000DBF")]
      public class GroupObj
      {
        [Token(Token = "0x40027F9")]
        [FieldOffset(Offset = "0x8")]
        public TacticsSceneCamera.AllRange.Group data;
        [Token(Token = "0x40027FA")]
        [FieldOffset(Offset = "0xC")]
        public int state;
        [Token(Token = "0x40027FB")]
        [FieldOffset(Offset = "0x10")]
        public float alpha;
        [Token(Token = "0x40027FC")]
        [FieldOffset(Offset = "0x14")]
        public List<TacticsSceneCamera.RenderSet> renders;

        [Token(Token = "0x6003786")]
        [Address(RVA = "0x10A1780", Offset = "0x10A0580", VA = "0x110A1780")]
        public GroupObj()
        {
        }
      }
    }

    [Token(Token = "0x2000DC0")]
    public class RenderSet
    {
      [Token(Token = "0x40027FD")]
      [FieldOffset(Offset = "0x8")]
      public List<MeshRenderer> meshRenderers;
      [Token(Token = "0x40027FE")]
      [FieldOffset(Offset = "0xC")]
      public List<SkinnedMeshRenderer> skinRenderers;
      [Token(Token = "0x40027FF")]
      [FieldOffset(Offset = "0x10")]
      public List<Material> materials;

      [Token(Token = "0x6003787")]
      [Address(RVA = "0x10A4070", Offset = "0x10A2E70", VA = "0x110A4070")]
      public RenderSet()
      {
      }
    }
  }
}
