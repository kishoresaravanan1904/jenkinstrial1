﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace jenkinstrial1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the jenkinstrial1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("321e527f-060e-47a5-8d41-40036646228e")]
    public partial class jenkinstrial1Repository : RepoGenBaseFolder
    {
        static jenkinstrial1Repository instance = new jenkinstrial1Repository();
        jenkinstrial1RepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the jenkinstrial1Repository element repository.
        /// </summary>
        [RepositoryFolder("321e527f-060e-47a5-8d41-40036646228e")]
        public static jenkinstrial1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public jenkinstrial1Repository() 
            : base("jenkinstrial1Repository", "/", null, 0, false, "321e527f-060e-47a5-8d41-40036646228e", ".\\RepositoryImages\\jenkinstrial1Repository321e527f.rximgres")
        {
            _rxmainframe = new jenkinstrial1RepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("321e527f-060e-47a5-8d41-40036646228e")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("87697f8f-3cd8-402b-a28d-f9888510987b")]
        public virtual jenkinstrial1RepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class jenkinstrial1RepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("87697f8f-3cd8-402b-a28d-f9888510987b")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _enteryournameInfo;
            RepoItemInfo _btnsubmitusernameInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@automationid='RxMainFrame']", parentFolder, 30000, null, true, "87697f8f-3cd8-402b-a28d-f9888510987b", "")
            {
                _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", "?/?/tabpage[@automationid='RxTabIntroduction']/?/?/text[@accessiblename='Enter your name']", ".//text[@accessiblename='Enter your name']", 30000, null, "9e09f8e0-1d66-47f4-bd37-2c18672d6d4d");
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "?/?/tabpage[@automationid='RxTabIntroduction']/button[@text='Submit']", ".//button[@text='Submit']", 30000, null, "e30ff176-e2c6-4bf8-bfbb-c364794afe68");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("87697f8f-3cd8-402b-a28d-f9888510987b")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("87697f8f-3cd8-402b-a28d-f9888510987b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EnterYourName item.
            /// </summary>
            [RepositoryItem("9e09f8e0-1d66-47f4-bd37-2c18672d6d4d")]
            public virtual Ranorex.Text EnterYourName
            {
                get
                {
                    return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterYourName item info.
            /// </summary>
            [RepositoryItemInfo("9e09f8e0-1d66-47f4-bd37-2c18672d6d4d")]
            public virtual RepoItemInfo EnterYourNameInfo
            {
                get
                {
                    return _enteryournameInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("e30ff176-e2c6-4bf8-bfbb-c364794afe68")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("e30ff176-e2c6-4bf8-bfbb-c364794afe68")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
