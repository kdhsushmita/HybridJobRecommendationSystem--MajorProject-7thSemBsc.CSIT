from django.urls import path

from recommendation.views import (
    CompanyDetailsAPI,
    JobDetailsView,
    JobApplyView,
    JobsPageAPI,
    JobSummaryView,
)
from recommendation.home_view import RecommendationView

urlpatterns = [
    path("job/<int:job_id>", JobDetailsView.as_view(), name="job_details"),
    path("job", JobApplyView.as_view(), name="apply_job"),
    path("jobs", JobsPageAPI.as_view(), name="list_all_jobs"),
    path(
        "company/<int:company_id>", CompanyDetailsAPI.as_view(), name="company_details"
    ),
    path("home", RecommendationView.as_view(), name="home_page"),
    path("job-summary", JobSummaryView.as_view(), name="job_summary"),
]
