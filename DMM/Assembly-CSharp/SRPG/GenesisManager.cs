// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024EA")]
  [AddComponentMenu("UI/Genesis/GenesisManager")]
  public class GenesisManager : MonoBehaviour
  {
    [Token(Token = "0x400A89C")]
    [FieldOffset(Offset = "0x0")]
    private static GenesisManager mInstance;
    [Token(Token = "0x400A89D")]
    [FieldOffset(Offset = "0x4")]
    private static GenesisChapterParam mCurrentChapterParam;
    [Token(Token = "0x400A89E")]
    [FieldOffset(Offset = "0x8")]
    private static List<GenesisManager.StarMissionInfo> mStarMissionInfoList;

    [Token(Token = "0x170016AE")]
    public static GenesisManager Instance
    {
      [Token(Token = "0x600A212"), Address(RVA = "0x643DF0", Offset = "0x642BF0", VA = "0x10643DF0")] get
      {
        return (GenesisManager) null;
      }
    }

    [Token(Token = "0x600A213")]
    [Address(RVA = "0x643890", Offset = "0x642690", VA = "0x10643890")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600A214")]
    [Address(RVA = "0x6437E0", Offset = "0x6425E0", VA = "0x106437E0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x170016AF")]
    public static GenesisChapterParam CurrentChapterParam
    {
      [Token(Token = "0x600A215"), Address(RVA = "0x643DB0", Offset = "0x642BB0", VA = "0x10643DB0")] get
      {
        return (GenesisChapterParam) null;
      }
      [Token(Token = "0x600A216"), Address(RVA = "0x643E30", Offset = "0x642C30", VA = "0x10643E30")] set
      {
      }
    }

    [Token(Token = "0x600A217")]
    public bool LoadAssets<T>(string name, GenesisManager.LoadAssetCallback<T> callback) where T : UnityEngine.Object
    {
      return new bool();
    }

    [Token(Token = "0x600A218")]
    private IEnumerator DownloadCoroutine<T>(
      string name,
      GenesisManager.LoadAssetCallback<T> callback)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600A219")]
    [Address(RVA = "0x643660", Offset = "0x642460", VA = "0x10643660")]
    public static bool IsGetStarMissionReward(
      string area_id,
      QuestDifficulties difficulty,
      int[] star_idx)
    {
      return new bool();
    }

    [Token(Token = "0x600A21A")]
    [Address(RVA = "0x643940", Offset = "0x642740", VA = "0x10643940")]
    public static void SetStarMissionInfo(ReqBtlCom.GenesisStar[] genesis_stars)
    {
    }

    [Token(Token = "0x600A21B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisManager()
    {
    }

    [Token(Token = "0x600A21C")]
    [Address(RVA = "0x643CF0", Offset = "0x642AF0", VA = "0x10643CF0")]
    static GenesisManager()
    {
    }

    [Token(Token = "0x20024EB")]
    public delegate void LoadAssetCallback<T>(T obj) where T : UnityEngine.Object;

    [Token(Token = "0x20024EC")]
    public class StarMissionInfo
    {
      [Token(Token = "0x400A89F")]
      [FieldOffset(Offset = "0x8")]
      public string mAreaId;
      [Token(Token = "0x400A8A0")]
      [FieldOffset(Offset = "0xC")]
      public GenesisManager.StarMissionInfo.Mode[] mMode;

      [Token(Token = "0x600A221")]
      [Address(RVA = "0x655EC0", Offset = "0x654CC0", VA = "0x10655EC0")]
      public StarMissionInfo(string area_id, int mode_len)
      {
      }

      [Token(Token = "0x20024ED")]
      public class Mode
      {
        [Token(Token = "0x400A8A1")]
        [FieldOffset(Offset = "0x8")]
        public bool[] mIsReward;

        [Token(Token = "0x600A222")]
        [Address(RVA = "0x655E50", Offset = "0x654C50", VA = "0x10655E50")]
        public Mode(int reward_len)
        {
        }
      }
    }
  }
}
