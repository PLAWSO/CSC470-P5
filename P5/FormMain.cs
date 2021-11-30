using Builder;
using System.Windows.Forms;
using System;

namespace P5
{
    public partial class FormMain : Form
    {
        public AppUser _CurrentAppUser = new AppUser();
        public Project _CurrentProject = new Project();
        public string selectedProject = "";
        FakeFeatureRepository fakeFeatureRepository = new FakeFeatureRepository();
        FakeRequirementRepository fakeRequirementRepository = new FakeRequirementRepository();

        public FormMain()
        {
            InitializeComponent();
        }

        private void preferencesCreateProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateProject form = new FormCreateProject();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            this.CenterToScreen();
            // Force the user to login successfully or abort the application
            DialogResult isOK = DialogResult.OK;
            while (!_CurrentAppUser.IsAuthenticated && isOK == DialogResult.OK)
            {
                FormLogin login = new FormLogin();
                isOK = login.ShowDialog();
                _CurrentAppUser = login._CurrentAppUser;
                login.Dispose();
            }
            if (isOK != DialogResult.OK)
            {
                Close();
                return;
            }
            this.Text = "Main - No Project Selected";
            while (selectAProject() == "")
            {
                DialogResult result = MessageBox.Show("A project must be selected.", "Attention", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }
        }

        private void preferencesSelectProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            selectAProject();
        }

        private string selectAProject()
        {
            FormSelectProject form = new FormSelectProject();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_NAME,
                                                   form._SelectedProjectName);
                int selectedProjectId = form._SelectedProjectId;
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID,
                                                   selectedProjectId.ToString());
                this.Text = "Main - " + form._SelectedProjectName;
                selectedProject = form._SelectedProjectName;
            }
            form.Dispose();
            return selectedProject;
        }

        private void preferencesModifyProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormModifyProject form = new FormModifyProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void preferencesRemoveProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRemoveProject form = new FormRemoveProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesDashboardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormIssueDashboard form = new FormIssueDashboard();
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesModifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            FormIssueSelect form = new FormIssueSelect(Int32.Parse(preferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID)), "Modify");
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRecordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormIssueRecorder form = new FormIssueRecorder();
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            FormIssueSelect form = new FormIssueSelect(Int32.Parse(preferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID)), "Remove");
            form.ShowDialog();
            form.Dispose();
        }

        private void requirementCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateRequirement form = new FormCreateRequirement(_CurrentProject.Id, fakeRequirementRepository, fakeFeatureRepository);
            form.ShowDialog();
            form.Dispose();
        }

        private void requirmentModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void requirementRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void featureCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateFeature form = new FormCreateFeature(_CurrentProject.Id, fakeFeatureRepository);
            form.ShowDialog();
            form.Dispose();
        }

        private void featureModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void featureRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
