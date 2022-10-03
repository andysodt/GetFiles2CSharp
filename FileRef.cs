using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;

namespace GetFiles2CSharp
{

    public class FileRef
    {
        private short mLocalOverWrittenVersionObsolete;
        private string mFileName;
        private string mLatestVersion;
        private string mLatestRevision;
        private string mNumber;
        private string mDescription;
        private string mCurrentState;
        private string mCheckedOutBy;
        private List<FileRef> mFileRefs;

        public FileRef()
        {

        }

        public string FileName
        {
            get { return mFileName; }
            set { mFileName = value; }
        }

        public string LatestVersion
        {
            get { return mLatestVersion; }
            set { mLatestVersion = value; }
        }

        public string LatestRevision
        {
            get { return mLatestRevision; }
            set { mLatestRevision = value; }
        }

        public string Number
        {
            get { return mNumber; }
            set { mNumber = value; }
        }

        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        public string CurrentState
        {
            get { return mCurrentState; }
            set { mCurrentState = value; }
        }

        public string CheckedOutBy
        {
            get { return mCheckedOutBy; }
            set { mCheckedOutBy = value; }
        }

        public short LocalOverWrittenVersionObsolete
        {
            get { return mLocalOverWrittenVersionObsolete; }
            set { mLocalOverWrittenVersionObsolete = value; }
        }

        public List<FileRef> FileRefs
        {
            get { return mFileRefs; }
            set { mFileRefs = value; }
        }
    }

}