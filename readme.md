# APSEB Setter (AvatarPoseSystem: ExtraBoneSetter)

## 概要

このツールは、Unityエディタ上で選択したGameObjectに`AvatarPoseSystemExtraBone`コンポーネントを簡単に追加・設定するためのエディタ拡張です。
`VRCPhysBone`が設定されているGameObjectに対して、その`rootTransform`を`AvatarPoseSystemExtraBone`の`rootTransform`に自動で設定します。

## インストール方法

1.  Unityの`Assets`フォルダ内に、この`APSEBSetter`フォルダを配置してください。
2.  Unityエディタが自動的にスクリプトをコンパイルし、ツールが利用可能になります。

## 使い方

1.  Unityエディタのヒエラルキー(Hierarchy)で、`VRCPhysBone`コンポーネントを持つGameObjectを選択します。
2.  メニューバーから `Tools > N > APSEB Setter` を選択します。
3.  選択したGameObjectに`AvatarPoseSystemExtraBone`コンポーネントが追加（または既存のものが利用）され、`rootTransform`が自動で設定されます。

## 依存関係

-   VRChat SDK (VRCPhysBoneのため)
-   Avatar Pose System (AvatarPoseSystemExtraBoneのため)
